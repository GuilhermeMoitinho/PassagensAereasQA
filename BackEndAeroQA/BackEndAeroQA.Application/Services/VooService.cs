using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Applicaton.Interfaces;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Application.Services
{
    public class VooService : IVooService
    {
        private readonly DbContextAeroporto _context;

        public VooService(DbContextAeroporto context)
        {
            _context = context;
        }

        public async Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos()
        {
            var TodosOsAeroportos = await _context.Aeroportos.ToListAsync();

            var response = new ServiceResponseCompraDoVoo<Aeroporto>
            {
                ProcessoConcluido = true,
                Dados = TodosOsAeroportos,
                Mensagem = "Tudo certo!"
            };

            return response;
        }
    }
}
