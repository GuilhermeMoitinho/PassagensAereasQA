using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Domain.Entity;
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
    }
}
