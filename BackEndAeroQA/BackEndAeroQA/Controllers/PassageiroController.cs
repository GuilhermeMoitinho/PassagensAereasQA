using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAeroQA.WebAPI.Controllers
{
    [Route("api/v1/passageiro")]
    [ApiController]
    public class PassageiroController : ControllerBase
    {
        private readonly IPassageiroService _passageiroService;

        public PassageiroController(IPassageiroService passageiroService)
        {
            _passageiroService = passageiroService;
        }

        [HttpPost("comprarpassagem")]
        public async Task<IActionResult> ComprarPassagem(string
            cpfDoPassageiro, PosuuiDespacho possuiDespacho, int numeroDoVoo)
        {
            return Ok(await _passageiroService.ComprarPassagem(cpfDoPassageiro, possuiDespacho, numeroDoVoo));
        }


        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarPassageiro([FromBody]Passageiro passageiro)
        {
            return Ok(await _passageiroService.CadastrarPassageiro(passageiro));
        }

        [HttpGet("passagem/{CPF}")]
        public async Task<IActionResult> PassagensPeloCPF(string CPF)
        {
            return Ok(await _passageiroService.PassagensPeloCPF(CPF));
        }


        [HttpDelete("passagem/{Cpf}")]
        public async Task<IActionResult> CancelarPassagem(string Cpf)
        {
            if(Cpf == null)
            {
                return NotFound();
            }

            await _passageiroService.CancelarComprar(Cpf);
            return NoContent(); 
        }

        [HttpPost("bagagem")]
        public async Task<IActionResult> EmitirBagagem(string cpf, bool extraviada, double pesoBagagem)
        {
            if (cpf == null)
            {
                return NotFound();
            }

            return Ok(await _passageiroService.EmitirBagagem(cpf, extraviada, pesoBagagem));
        }


    }
}