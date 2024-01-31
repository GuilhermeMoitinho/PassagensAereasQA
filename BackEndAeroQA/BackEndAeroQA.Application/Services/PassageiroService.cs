using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Domain.Enum;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class PassageiroService : IPassageiroService
    {
        private readonly AppDbContext _passageiroContext;
        private readonly DbContextVoo _vooContext;
        private readonly AppDbContextVoucher _voucherContext;

        public PassageiroService(AppDbContext passageiroContext, DbContextVoo vooContext, AppDbContextVoucher voucherContext)
        {
            _passageiroContext = passageiroContext;
            _vooContext = vooContext;
            _voucherContext = voucherContext;
        }

        public async Task<ServiceResponseCompraDoVoo<Passageiro>> CadastrarPassageiro(Passageiro passageiro)
        {
            var response = new ServiceResponseCompraDoVoo<Passageiro>();

            if(passageiro.Id != null)
            {
                passageiro.Id = Guid.NewGuid();
            }

            if(passageiro == null)
            {
                response = new ServiceResponseCompraDoVoo<Passageiro>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "O passageiro não foi adicionando com sucesso!"
                };
            }

            await _passageiroContext.Passageiros.AddAsync(passageiro);
            await _passageiroContext.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<Passageiro>
            {
                ProcessoConcluido = true,
                Dados = passageiro.Id,
                Mensagem = "Passageiro adicionando com sucesso!"
            };

            return response;
        }
        public async Task CancelarComprar(string Cpf)
        {
            var PassagensExistentes = await _voucherContext.Vouchers.FirstOrDefaultAsync(voucher => voucher.CpfPassageiro == Cpf);

            if (PassagensExistentes != null)
            {
                _voucherContext.Vouchers.Remove(PassagensExistentes);
                await _voucherContext.SaveChangesAsync();
            }
        }

        public async Task<ServiceResponseCompraDoVoo<Voucher>> ComprarPassagem(string cpfDoPassageiro, PosuuiDespacho possuiDespacho, int numeroDoVoo)
        {
            var response = new ServiceResponseCompraDoVoo<Voucher>();

            var voucherDeRetorno = new Voucher();

            var passageiroExistente = await _passageiroContext.Passageiros.FirstOrDefaultAsync(cpf => cpf.Cpf == cpfDoPassageiro);

            var VooEspecifico = await _vooContext.Voos
                .FirstOrDefaultAsync(NumeroDoVoo => NumeroDoVoo.CodigoIATA == numeroDoVoo);

            if (passageiroExistente == null || VooEspecifico == null)
            {
                response = new ServiceResponseCompraDoVoo<Voucher>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique se o voo é existente ou se seu passageiro existe."
                };

                return response;
            }

            // Adicionando ao voucher
            voucherDeRetorno.NumeroVoo = VooEspecifico.CodigoIATA;
            voucherDeRetorno.PossuiDespachoBagagem = possuiDespacho;
            voucherDeRetorno.Origem = VooEspecifico.Origem;
            voucherDeRetorno.Destino = VooEspecifico.Destino;
            voucherDeRetorno.NomePassageiro = passageiroExistente.Name;
            voucherDeRetorno.CpfPassageiro = passageiroExistente.Cpf;

            // Alterando no Voo
            VooEspecifico.Passageiros.Add($"{voucherDeRetorno.NomePassageiro} {voucherDeRetorno.CpfPassageiro}");

            // Salvando o voucher no banco
            await _voucherContext.Vouchers.AddAsync(voucherDeRetorno);
            await _voucherContext.SaveChangesAsync();

            // Salvando o voo no banco
            _vooContext.Voos.Update(VooEspecifico);
            await _vooContext.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<Voucher>
            {
                ProcessoConcluido = true,
                Dados = voucherDeRetorno,
                Mensagem = "Passagem comprada com sucesso."
            };

            return response;
        }

        public Task<ServiceResponseCompraDoVoo<Bagagem>> EmitirBagagem(string cpf)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponseCompraDoVoo<Voucher>> PassagensPeloCPF(string CPF)
        {
            var response = new ServiceResponseCompraDoVoo<Voucher>();

            var PassagensExistentes = await _voucherContext.Vouchers.FirstOrDefaultAsync(cpf => cpf.CpfPassageiro == CPF);

            if(PassagensExistentes == null)
            {
                response = new ServiceResponseCompraDoVoo<Voucher>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Nenhuma passagem encontrada."
                };
            }

            response = new ServiceResponseCompraDoVoo<Voucher>
            {
                ProcessoConcluido = true,
                Dados = PassagensExistentes,
                Mensagem = "Passagem encontrada."
            };

            return response;
        }
    }
}
