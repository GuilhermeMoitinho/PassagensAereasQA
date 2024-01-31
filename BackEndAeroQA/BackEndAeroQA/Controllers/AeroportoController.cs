using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Applicaton.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAeroQA.WebAPI.Controllers
{
    [Route("api/v1/aeroporto")]
    [ApiController]
    public class AeroportoController : ControllerBase
    {
        private readonly IAeroportoService _AeroportoService;

        public AeroportoController(IAeroportoService aeroportoService)
        {
            _AeroportoService = aeroportoService;
        }

        [Authorize]
        [HttpGet("aeroportos")]
        public async Task<IActionResult> ListarAeroportos(int peginaNumero = 0, int quantNumeros = 20)
        {
            return Ok(await _AeroportoService.ListarAeroportos(peginaNumero, quantNumeros));
        }

    }
}
