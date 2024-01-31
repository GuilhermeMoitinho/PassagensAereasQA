using AutoMapper;
using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.Mapper.Mappings;
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
        private readonly AppDbContextBagagem _bagagemContext;
        private readonly IMapper _mapper;

        public PassageiroService(AppDbContext passageiroContext, DbContextVoo vooContext, AppDbContextVoucher voucherContext, AppDbContextBagagem bagagemContext, IMapper mapper)
        {
            _passageiroContext = passageiroContext;
            _vooContext = vooContext;
            _voucherContext = voucherContext;
            _bagagemContext = bagagemContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponseCompraDoVoo<PassageiroDto>> CadastrarPassageiro(PassageiroDto passageiroDto)
        {
            var response = new ServiceResponseCompraDoVoo<PassageiroDto>();
            var buscaId = await _passageiroContext.Passageiros.FirstOrDefaultAsync(id => id.Id == passageiroDto.Id);

            var passageiro = _mapper.Map<Passageiro>(passageiroDto);

            var PassageiroExistenteCpf = await _passageiroContext.Passageiros
                .FirstOrDefaultAsync(cliente => cliente.Cpf == passageiro.Cpf);

            if (PassageiroExistenteCpf != null)
            {
                response = new ServiceResponseCompraDoVoo<PassageiroDto>
                {
                    ProcessoConcluido = false,
                    Dados = null,
                    Mensagem = "Seu CPF já foi cadastrado!"
                };

                return response;
            }

            if (buscaId != null)
            {
                passageiro.Id = Guid.NewGuid();
            }

            _passageiroContext.Passageiros.Add(passageiro);
            await _passageiroContext.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<PassageiroDto>
            {
                ProcessoConcluido = true,
                Dados = _mapper.Map<PassageiroDto>(passageiro),
                Mensagem = "Passageiro adicionado com sucesso!"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Voucher>> CancelarComprar(string Cpf)
        {
            var response = new ServiceResponseCompraDoVoo<Voucher>();
            var PassagensExistentes = await _voucherContext.Vouchers.FirstOrDefaultAsync(voucher => voucher.CpfPassageiro == Cpf);

            if(PassagensExistentes == null)
            {
                response = new ServiceResponseCompraDoVoo<Voucher>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Esse Cpf é inválido!"
                };

                return response;
            }

            _voucherContext.Vouchers.Remove(PassagensExistentes);
            await _voucherContext.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<Voucher>
            {
                ProcessoConcluido = true,
                Dados = Cpf,
                Mensagem = "Dados removidos com sucesso!"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Voucher>> ComprarPassagem(string cpfDoPassageiro, PosuuiDespacho possuiDespacho, int numeroDoVoo)
        {
            var response = new ServiceResponseCompraDoVoo<Voucher>();

            var voucherDeRetorno = new Voucher();

            var passageiroExistente = await _passageiroContext.Passageiros.FirstOrDefaultAsync(cpf => cpf.Cpf == cpfDoPassageiro);  

            var VooEspecifico = await _vooContext.Voos
                .FirstOrDefaultAsync(NumeroDoVoo => NumeroDoVoo.NumeroDoVoo == numeroDoVoo);

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
            voucherDeRetorno.NumeroVoo = VooEspecifico.NumeroDoVoo;
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
                Mensagem = $"Passagem comprada com sucesso, {passageiroExistente.Name}"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Bagagem>> EmitirBagagem(string cpf, bool extraviada, double pesoBagagem)
        {
            var response = new ServiceResponseCompraDoVoo<Bagagem>();
            var ProcurarVoucher = await _voucherContext.Vouchers.FirstOrDefaultAsync(CPF => CPF.CpfPassageiro == cpf);
            var Bagagem = new Bagagem();

            var PassageiroTemPassagem = await PassagensPeloCPF(cpf);

            if(PassageiroTemPassagem.Dados == null)
            {
                response = new ServiceResponseCompraDoVoo<Bagagem>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Seu passageiro não tem bagagem!"
                };

                return response;
            }

            Bagagem.Descricao = "Origem: " + ProcurarVoucher.Origem + " e Destino: " + ProcurarVoucher.Destino;
            Bagagem.CpfPassageiro = ProcurarVoucher.CpfPassageiro;
            Bagagem.Extraviada = extraviada;
            Bagagem.Peso = pesoBagagem;

            if(ProcurarVoucher == null)
            {
                response = new ServiceResponseCompraDoVoo<Bagagem>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique suas credenciais!"
                };

                return response;
            }

            await _bagagemContext.Bagagens.AddAsync(Bagagem);
            await _bagagemContext.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<Bagagem>
            {
                ProcessoConcluido = true,
                Dados = Bagagem,
                Mensagem = "Etiqueta da Bagagem emitida com sucesso!"
            };

            return response;
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

                return response;
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
