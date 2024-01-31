using BackEndAeroQA.Application.Mapper.Mappings;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Applicaton.Interfaces
{
    public interface IVooService
    {
        Task<ServiceResponseCompraDoVoo<VooDto>> CadastrarVoos(VooDto vooDto);
        Task<ServiceResponseCompraDoVoo<Voo>> ListarVoos(int peginaNumeros, int quantNumeros);
        Task<ServiceResponseCompraDoVoo<VooDto>> BuscarVoo(Guid id);
        Task AlterarVoo(VooDto vooDto);
        Task CancelarVoo(Guid id);
        Task<ServiceResponseCompraDoVoo<VooDto>> ListarPassageirosEmVooEspecifico(Guid id);
        Task<ServiceResponseCompraDoVoo<VooDto>> ListarVoosEmDataEspecifica(DateTime DataPartidaa, DateTime DataChegada);

    }
}
