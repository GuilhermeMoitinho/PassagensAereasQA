using AutoMapper;
using BackEndAeroQA.Application.Mapper.Mappings;
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
        private readonly IMapper _mapper;

        public VooService(DbContextVoo contextVoo, IMapper mapper)
        {
            _contextVoo = contextVoo;
            _mapper = mapper;
        }

        public async Task AlterarVoo(VooDto vooDto)
        {
            var VooExistente = await _contextVoo.Voos.FindAsync(vooDto.Id);

            VooExistente.Origem = vooDto.Origem;
            VooExistente.Destino = vooDto.Destino;
            VooExistente.DataHoraDePartida = vooDto.DataHoraDePartida;
            VooExistente.DataHoraDeChegada = vooDto.DataHoraDeChegada;
            VooExistente.Tipo = vooDto.Tipo;
            VooExistente.QuantidadeDosAssentos = vooDto.QuantidadeDosAssentos;
            VooExistente.Passageiros = vooDto.Passageiros;
            VooExistente.ValorDoAssento = vooDto.ValorDoAssento;

            _mapper.Map(vooDto, VooExistente);

            _contextVoo.Voos.Update(VooExistente);
            await _contextVoo.SaveChangesAsync();
        }

        public async Task<ServiceResponseCompraDoVoo<VooDto>> BuscarVoo(Guid id)
        {
            var VooBuscado = await _contextVoo.Voos.FirstOrDefaultAsync(v => v.Id == id);

            var response = new ServiceResponseCompraDoVoo<VooDto>
            {
                ProcessoConcluido = true,
                Dados = _mapper.Map<VooDto>(VooBuscado),
                Mensagem = "Tudo certo!"
            };

            return response;
        }


        public async Task<ServiceResponseCompraDoVoo<VooDto>> CadastrarVoos(VooDto vooDto)
        {
            var response = new ServiceResponseCompraDoVoo<VooDto>();

            if (vooDto is null)
            {
                response = new ServiceResponseCompraDoVoo<VooDto>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique suas credenciais!"
                };
                return response;
            }

            // Mapeando o VooDto para Voo
            var voo = _mapper.Map<Voo>(vooDto);

            await _contextVoo.Voos.AddAsync(voo);
            await _contextVoo.SaveChangesAsync();

            response = new ServiceResponseCompraDoVoo<VooDto>
            {
                ProcessoConcluido = true,
                Dados = _mapper.Map<VooDto>(voo),
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


        public async Task<ServiceResponseCompraDoVoo<VooDto>> ListarPassageirosEmVooEspecifico(Guid id)
        {
            var response = new ServiceResponseCompraDoVoo<VooDto>();

            var VooEspecifico = await _contextVoo.Voos.FirstOrDefaultAsync(v => v.Id == id);

            if (VooEspecifico == null)
            {
                response = new ServiceResponseCompraDoVoo<VooDto>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Verifique suas credenciais!"
                };

                return response;
            }

            // Mapeando a lista de passageiros do Voo para List<string>
            var TodosOsPassageiros = _mapper.Map<List<string>>(VooEspecifico.Passageiros);

            response = new ServiceResponseCompraDoVoo<VooDto>
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

        public async Task<ServiceResponseCompraDoVoo<VooDto>> ListarVoosEmDataEspecifica(DateTime DataPartidaa, DateTime DataChegada)
        {
            var response = new ServiceResponseCompraDoVoo<VooDto>();

            var DataPartidaEspecif = await _contextVoo.Voos
                .FirstOrDefaultAsync(v => v.DataHoraDePartida == DataPartidaa && v.DataHoraDeChegada == DataChegada);

            if (DataPartidaEspecif == null)
            {
                response = new ServiceResponseCompraDoVoo<VooDto>
                {
                    ProcessoConcluido = true,
                    Dados = null,
                    Mensagem = "Seus voos não estão disponíveis!"
                };

                return response;
            }

            response = new ServiceResponseCompraDoVoo<VooDto>
            {
                ProcessoConcluido = true,
                Dados = _mapper.Map<VooDto>(DataPartidaEspecif),
                Mensagem = "Seus voos disponíveis!"
            };

            return response;
        }
    }
}
