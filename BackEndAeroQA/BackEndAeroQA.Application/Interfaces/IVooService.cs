using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Applicaton.Interfaces
{
    public interface IVooService
    {
        Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos();

    }
}
