using BackEndAeroQA.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class DbContextAeroporto : DbContext
    {
        public DbSet<Aeroporto> Aeroportos { get; set; }

        public DbContextAeroporto(DbContextOptions<DbContextAeroporto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var aeroportos = new List<Aeroporto>
            {
                new Aeroporto { Id = Guid.NewGuid(), Codigo = 1000, Cidade = "Rio de Janeiro", UF = "RJ" },
                new Aeroporto { Id = Guid.NewGuid(), Codigo = 1001, Cidade = "São Paulo", UF = "SP" },
                new Aeroporto { Id = Guid.NewGuid(), Codigo = 1002, Cidade = "Belo Horizonte", UF = "MG" },
                new Aeroporto { Id = Guid.NewGuid(), Codigo = 1003, Cidade = "Brasília", UF = "DF" },
                new Aeroporto { Id = Guid.NewGuid(), Codigo = 1004, Cidade = "Salvador", UF = "BA" },
                // Add more airports here
            };

            modelBuilder.Entity<Aeroporto>().HasData(aeroportos);
        }
    }
}