using BackEndAeroQA.Applicaton.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAeroQA.WebAPI.Controllers
{
    [Route("api/v1/voo")]
    [ApiController]
    public class VooController : ControllerBase
    {

        private readonly IVooService _VooService;

        public VooController(IVooService vooService)
        {
            _VooService = vooService;
        }

        [Authorize]
        [HttpGet("voos")]
        public async Task<IActionResult> ListarVoos(int peginaNumeros = 0, int quantNumeros = 30)
        {
            return Ok(await _VooService.ListarVoos(peginaNumeros, quantNumeros));
        }

        [HttpGet("voo/{DataPartidaa}/{DataChegada}")]
        public async Task<IActionResult> ListarVoosEmDataEspecifica(DateTime DataPartidaa, DateTime DataChegada)
        {
            if(DataPartidaa.Day > DataChegada.Day)
            {
                return BadRequest();
            }

            return Ok(await _VooService.ListarVoosEmDataEspecifica(DataPartidaa, DataChegada));
        }

        [Authorize]
        [HttpDelete("cancelar")]
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

        [Authorize]
        [HttpGet("voo/{id}/passageiros")]
        public async Task<IActionResult> BuscarVoListarPassageirosEmVooEspecificooPorId(Guid id)
        {
            return Ok(await _VooService.ListarPassageirosEmVooEspecifico(id));
        }

        [Authorize]
        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarVoos(Voo voo)
        {
            var IdExistente = await _VooService.BuscarVoo(voo.Id);


            if (voo.DataHoraDePartida.Day > voo.DataHoraDeChegada.Day)
            {
                return BadRequest();
            }

            if (IdExistente != null)
            {
                voo.Id = Guid.NewGuid();
            }

            var result = await _VooService.CadastrarVoos(voo);

            return CreatedAtAction(nameof(BuscarVooPorId), new { id = result.Dados }, result);
        }

        [Authorize]
        [HttpPut("edite")]
        public async Task<IActionResult> AlterarVoos(Voo voo)
        {
            if (voo == null) return BadRequest();

            if (voo.DataHoraDePartida.Day > voo.DataHoraDeChegada.Day)
            {
                return BadRequest();
            }

            if (voo.Id == null) return NotFound();

            await _VooService.AlterarVoo(voo);

            return NoContent();
        }


    }
}
