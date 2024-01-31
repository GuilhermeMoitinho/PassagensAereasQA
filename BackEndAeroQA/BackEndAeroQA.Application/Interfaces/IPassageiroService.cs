using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Domain.Enum;

namespace BackEndAeroQA.Application.Interfaces
{
    public interface IPassageiroService
    {
        Task<ServiceResponseCompraDoVoo<Voucher>> ComprarPassagem(string cpfDoPassageiro, PosuuiDespacho possuiDespacho, int numeroDoVoo);

        Task<ServiceResponseCompraDoVoo<Passageiro>> CadastrarPassageiro(Passageiro passageiro);

        Task<ServiceResponseCompraDoVoo<Voucher>> PassagensPeloCPF(string CPF);

        Task CancelarComprar(string cpf);

        Task<ServiceResponseCompraDoVoo<Bagagem>> EmitirBagagem(string cpf, bool extraviada, double pesoBagagem);

    }
}
