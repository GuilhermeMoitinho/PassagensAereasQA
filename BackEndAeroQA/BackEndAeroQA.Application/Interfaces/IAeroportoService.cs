using BackEndAeroQA.Application.ServicoDeResposta;
using BackEndAeroQA.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAeroQA.Application.Interfaces
{
    public interface IAeroportoService
    {
        Task<ServiceResponseCompraDoVoo<Aeroporto>> ListarAeroportos(int peginaNumeros, int quantNumeros);
    }
}
