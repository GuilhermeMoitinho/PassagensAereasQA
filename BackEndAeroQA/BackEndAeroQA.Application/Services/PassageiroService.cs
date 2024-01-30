using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class PassageiroService : IPassageiroService
    {
        private readonly AppDbContext _PassageiroContext;

        public PassageiroService(AppDbContext passageiroContext)
        {
            _PassageiroContext = passageiroContext;
        }

        public Task<ServiceResponseCompraDoVoo<Vouncher>> ComprarPassagem(Passageiro passageiro, Voo vooEspecifico)
        {
            throw new NotImplementedException();
        }
    }
}
