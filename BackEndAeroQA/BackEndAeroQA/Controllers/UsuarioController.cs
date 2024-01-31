using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAeroQA.WebAPI.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]Usuario usuario)
        {
            var user = await _usuarioService.ObterUsuarioMestre(usuario.Email, usuario.Senha);

            if (user ==null)
            {
                return NotFound();
            }
            
            return Ok(await _usuarioService.Login(usuario));
        }
    }
}
