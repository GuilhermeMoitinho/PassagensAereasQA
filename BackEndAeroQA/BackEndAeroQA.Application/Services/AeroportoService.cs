using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAeroQA.Application.Services
{
    public class AeroportoService : IAeroportoService
    {

        private readonly DbContextAeroporto _contextAeroporto;

        public AeroportoService(DbContextAeroporto contextAeroporto)
        {
            _contextAeroporto = contextAeroporto;
        }

        public async Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos(int peginaNumeros, int quantNumeros)
        {
            var TodosOsAeroportos = await _contextAeroporto.Aeroportos.
                    Skip(peginaNumeros * quantNumeros).
                    Take(quantNumeros).
                    ToListAsync();

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
