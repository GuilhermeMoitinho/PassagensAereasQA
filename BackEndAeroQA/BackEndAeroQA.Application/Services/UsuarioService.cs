using BackEndAeroQA.Application.Auth;
using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly TokenService _tokenService;
        private readonly AppDbContextUsuario _usuarioContext;

        public UsuarioService(TokenService tokenService, AppDbContextUsuario usuarioContext)
        {
            _tokenService = tokenService;
            _usuarioContext = usuarioContext;
        }

        public async Task<ServiceResponseUsuario<Usuario>> Login(Usuario userLogin)
        {
            var response = new ServiceResponseUsuario<Usuario>();

            var user = await ObterUsuarioMestre(userLogin.Email, userLogin.Senha);

            if (user != null)
            {
               var token = _tokenService.GenerateToken(userLogin);

                response = new ServiceResponseUsuario<Usuario>
                {
                    Id = userLogin.Id,
                    Email = userLogin.Email,
                    Token = token
                };
            }

            return response;
        }

        public async Task<Usuario> ObterUsuarioMestre(string email, string senha)
        {
            var user = await _usuarioContext.Usuarios.AsNoTracking()
                                           .Where(u => u.Email == email && u.Senha == senha)
                                           .FirstOrDefaultAsync();

            return user;
        }
    }
}
