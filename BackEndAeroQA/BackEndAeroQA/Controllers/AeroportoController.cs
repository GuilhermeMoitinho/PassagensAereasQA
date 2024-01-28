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

        [HttpGet]
        public async Task<IActionResult> ListarAeroportos()
        {
            return Ok(await _VooService.ListarAeroportos());
        }
    }
}
