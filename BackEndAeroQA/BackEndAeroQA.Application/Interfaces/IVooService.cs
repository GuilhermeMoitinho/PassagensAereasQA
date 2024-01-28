using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Applicaton.Interfaces
{
    public interface IVooService
    {
        Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos();
        Task<ServiceResponseCompraDoVoo<Voo>> CadastrarVoos(Voo voos);
        Task<ServiceResponseCompraDoVoo<Voo>> ListarVoos(int peginaNumeros, int quantNumeros);
        Task<ServiceResponseCompraDoVoo<Voo>> BuscarVoo(Guid id);
        Task AlterarVoo(Voo voor);
        Task CancelarVoo(Guid id);


    }
}
