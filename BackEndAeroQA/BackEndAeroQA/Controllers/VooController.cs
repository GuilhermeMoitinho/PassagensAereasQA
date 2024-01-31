using BackEndAeroQA.Application.Mapper.Mappings;
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

        [Authorize]
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
        public async Task<IActionResult> CadastrarVoos(VooDto vooDto)
        {
            var IdExistente = await _VooService.BuscarVoo(vooDto.Id);


            if (vooDto.DataHoraDePartida.Day > vooDto.DataHoraDeChegada.Day)
            {
                return BadRequest();
            }

            if (IdExistente != null)
            {
                vooDto.Id = Guid.NewGuid();
            }

            var result = await _VooService.CadastrarVoos(vooDto);

            return CreatedAtAction(nameof(BuscarVooPorId), new { id = result.Dados }, result);
        }

        [Authorize]
        [HttpPut("edite")]
        public async Task<IActionResult> AlterarVoos(VooDto vooDto)
        {
            if (vooDto == null) return BadRequest();

            if (vooDto.DataHoraDePartida.Day > vooDto.DataHoraDeChegada.Day)
            {
                return BadRequest();
            }

            if (vooDto.Id == null) return NotFound();

            await _VooService.AlterarVoo(vooDto);

            return NoContent();
        }


    }
}
