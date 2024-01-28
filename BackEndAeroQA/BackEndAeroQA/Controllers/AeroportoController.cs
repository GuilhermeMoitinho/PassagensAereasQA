using BackEndAeroQA.Applicaton.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAeroQA.WebAPI.Controllers
{
    [Route("api/aeroportos")]
    [ApiController]
    public class AeroportoController : ControllerBase
    {
        private readonly IVooService _VooService;

        public AeroportoController(IVooService vooService)
        {
            _VooService = vooService;
        }

        [HttpGet("aeroportos")]
        public async Task<IActionResult> ListarAeroportos()
        {
            return Ok(await _VooService.ListarAeroportos());
        }

        [HttpGet("voos")]
        public async Task<IActionResult> ListarVoos(int peginaNumeros = 1, int quantNumeros = 30)
        {
            return Ok(await _VooService.ListarVoos(peginaNumeros, quantNumeros));
        }

        [HttpDelete("voosDel")]
        public async Task<IActionResult> CancelarVoo(Guid id)
        {
            await _VooService.CancelarVoo(id);

            return NoContent();
        }

        [ActionName("BuscarVooPorId")]
        [HttpGet("voo/{id}")]
        public async Task<IActionResult> BuscarVooPorId(Guid id)
        {
            return Ok(await _VooService.BuscarVoo(id));
        }

        [HttpPost("voo")]
        public async Task<IActionResult> CadastrarVoos(Voo voo)
        {
            if (voo == null) return BadRequest();

            var result = await _VooService.CadastrarVoos(voo);

            return CreatedAtAction(nameof(BuscarVooPorId), new {id = result.Dados}, result);
        }

        [HttpPut("voo")]
        public async Task<IActionResult> AlterarVoos(Voo voo)
        {
            if (voo == null) return BadRequest();

            if (voo.Id == null) return NotFound();

            await _VooService.AlterarVoo(voo);

            return NoContent();
        }



    }
}
