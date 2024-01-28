using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Applicaton.Interfaces;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class VooService : IVooService
    {
        private readonly DbContextAeroporto _contextAeroporto;
        private readonly DbContextVoo _contextVoo;

        public VooService(DbContextAeroporto contextAeroporto, DbContextVoo contextVoo)
        {
            _contextAeroporto = contextAeroporto;
            _contextVoo = contextVoo;
        }

        public async Task AlterarVoo(Voo voor)
        {
            var vooExistente = _contextVoo.Voos.FirstOrDefault(v => v.Id == voor.Id);

            vooExistente.Origem = voor.Origem;
            vooExistente.Destino = voor.Destino;
            vooExistente.DataHoraDePartida = voor.DataHoraDePartida;
            vooExistente.DataHoraDeChegada = voor.DataHoraDeChegada;
            vooExistente.Tipo = voor.Tipo;
            vooExistente.QuantidadeDosAssentos = voor.QuantidadeDosAssentos;
            vooExistente.ValorDoAssento = voor.ValorDoAssento;

             _contextVoo.Voos.Update(vooExistente);
            await _contextVoo.SaveChangesAsync();
        }

        public async Task<ServiceResponseCompraDoVoo<Voo>> BuscarVoo(Guid id)
        {
            var VooBuscado = await _contextVoo.Voos.FirstOrDefaultAsync(v => v.Id == id);

            var response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = VooBuscado,
                Mensagem = "Tudo certo!"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Voo>> CadastrarVoos(Voo voos)
        {
            await _contextVoo.Voos.AddAsync(voos);
            await _contextVoo.SaveChangesAsync();

            var response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = voos.Id,
                Mensagem = "Voo criado com sucesso"
            };

            return response;

        }

        public async Task CancelarVoo(Guid id)
        {
            var vooParaRemover = await _contextVoo.Voos.FirstOrDefaultAsync(v => v.Id == id);

            _contextVoo.Voos.Remove(vooParaRemover);
            await _contextVoo.SaveChangesAsync();
        }

        public async Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos()
        {
            var TodosOsAeroportos = await _contextAeroporto.Aeroportos.ToListAsync();

            var response = new ServiceResponseCompraDoVoo<Aeroporto>
            {
                ProcessoConcluido = true,
                Dados = TodosOsAeroportos,
                Mensagem = "Tudo certo!"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Voo>> ListarVoos(int peginaNumeros, int quantNumeros)
        {
            var TodosOsVoos = await _contextVoo.Voos.Skip(peginaNumeros * quantNumeros).Take(quantNumeros).ToListAsync();


            var response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = TodosOsVoos,
                Mensagem = "Tudo certo!"
            };

            return response;

        }
    }
}
