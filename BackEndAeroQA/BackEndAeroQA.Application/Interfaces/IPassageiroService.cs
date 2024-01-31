using BackEndAeroQA.Application.Mapper.Mappings;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Domain.Enum;

namespace BackEndAeroQA.Application.Interfaces
{
    public interface IPassageiroService
    {
        Task<ServiceResponseCompraDoVoo<Voucher>> ComprarPassagem(string cpfDoPassageiro, PosuuiDespacho possuiDespacho, int numeroDoVoo);

        Task<ServiceResponseCompraDoVoo<PassageiroDto>> CadastrarPassageiro(PassageiroDto passageiro);

        Task<ServiceResponseCompraDoVoo<Voucher>> PassagensPeloCPF(string CPF);

        Task<ServiceResponseCompraDoVoo<Voucher>> CancelarComprar(string Cpf);

        Task<ServiceResponseCompraDoVoo<Bagagem>> EmitirBagagem(string cpf, bool extraviada, double pesoBagagem);

    }
}
