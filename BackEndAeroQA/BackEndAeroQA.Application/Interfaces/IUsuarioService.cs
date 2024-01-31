using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<ServiceResponseUsuario<Usuario>> Login(Usuario userLogin);

        Task<Usuario> ObterUsuarioMestre(string email, string senha);
    }
}
