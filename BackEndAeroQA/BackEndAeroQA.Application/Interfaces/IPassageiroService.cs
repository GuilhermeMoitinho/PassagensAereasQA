using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Application.Interfaces
{
    public interface IPassageiroService
    {
        Task<ServiceResponseCompraDoVoo<Vouncher>> ComprarPassagem(Passageiro passageiro, Voo vooEspecifico);
    }
}
