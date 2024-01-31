using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Applicaton.Interfaces;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class VooService : IVooService
    {
        private readonly DbContextVoo _contextVoo;

        public VooService(DbContextVoo contextVoo)
        {
            _contextVoo = contextVoo;
        }

        public async Task AlterarVoo(Voo voor)
        {
            var VooExistente = await _contextVoo.Voos.FindAsync(voor.Id);

            VooExistente.Origem = voor.Origem;
            VooExistente.Destino = voor.Destino;
            VooExistente.DataHoraDePartida = voor.DataHoraDePartida;
            VooExistente.DataHoraDeChegada = voor.DataHoraDeChegada;
            VooExistente.Tipo = voor.Tipo;
            VooExistente.QuantidadeDosAssentos = voor.QuantidadeDosAssentos;
            VooExistente.Passageiros = voor.Passageiros;
            VooExistente.ValorDoAssento = voor.ValorDoAssento;

             _contextVoo.Voos.Update(VooExistente);
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
            var response = new ServiceResponseCompraDoVoo<Voo>();

            if (voos is null)
            {
                response = new ServiceResponseCompraDoVoo<Voo>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique suas credenciais!"
                };
                return response;
            }


            await _contextVoo.Voos.AddAsync(voos);
            await _contextVoo.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<Voo>
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


        public async Task<ServiceResponseCompraDoVoo<Voo>> ListarPassageirosEmVooEspecifico(Guid id)
        {
            var response = new ServiceResponseCompraDoVoo<Voo>();

            var VooEspecifico = await _contextVoo.Voos.FirstOrDefaultAsync(ps => ps.Id == id);

            var TodosOsPassageiros = VooEspecifico.Passageiros.ToList();

            if (id == Guid.Empty)
            {
                response = new ServiceResponseCompraDoVoo<Voo>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique suas credenciais!"
                };

                return response;
            }

            response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = TodosOsPassageiros,
                Mensagem = "Aqui está seus passageiros!"
            };

            return response;
        }

        public async Task<ServiceResponseCompraDoVoo<Voo>> ListarVoos(int peginaNumeros, int quantNumeros)
        {
            var response = new ServiceResponseCompraDoVoo<Voo>();

            var TodosOsVoos = await _contextVoo.Voos.Skip(peginaNumeros * quantNumeros).Take(quantNumeros).ToListAsync();

            if(TodosOsVoos is null)
            {
                response = new ServiceResponseCompraDoVoo<Voo>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Você não tem voos disponiveis!"
                };

                return response;
            }


             response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = TodosOsVoos,
                Mensagem = "Tudo certo!"
            };

            return response;

        }

        public async Task<ServiceResponseCompraDoVoo<Voo>> ListarVoosEmDataEspecifica(DateTime DataPartidaa, DateTime DataChegada)
        {

            var response = new ServiceResponseCompraDoVoo<Voo>();

                var DataPartidaEspecif = await _contextVoo.Voos.
                FirstOrDefaultAsync
                (DataPartidaExistente => DataPartidaExistente.DataHoraDePartida == DataPartidaa 
                && DataPartidaExistente.DataHoraDeChegada == DataChegada);



            if (DataPartidaEspecif == null)
            {
                response = new ServiceResponseCompraDoVoo<Voo>
                {
                    ProcessoConcluido = true,
                    Dados = DataPartidaEspecif,
                    Mensagem = "Seus voos não estão disponiveis!"
                };

                return response;
            }

            response = new ServiceResponseCompraDoVoo<Voo>
            {
                ProcessoConcluido = true,
                Dados = DataPartidaEspecif,
                Mensagem = "Seus voos disponiveis!"
            };


            return response;

        }
    }
}
