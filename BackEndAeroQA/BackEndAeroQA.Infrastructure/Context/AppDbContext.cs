using BackEndAeroQA.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {        
        }

        public DbSet<Passageiro> Passageiros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var random = new Random();
            var passageiros = Enumerable.Range(1, 100).Select(i =>
            {
                return new Passageiro
                {
                    Id = Guid.NewGuid(),
                    Cpf = $"CPF{i}",
                    Name = $"Passageiro {i}",
                    DataDeNascimento = DateTime.Now.AddYears(-random.Next(18, 60)),
                    Email = $"passageiro{i}@exemplo.com"
                };
            }).ToList();

            modelBuilder.Entity<Passageiro>().HasData(passageiros);
        }
    }
}
