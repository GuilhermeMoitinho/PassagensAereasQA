using BackEndAeroQA.Domain.Enum;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class DbContextVoo : DbContext
    {
        public DbSet<Voo> Voos { get; set; }

        public DbContextVoo(DbContextOptions<DbContextVoo> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var random = new Random();

            var voos = Enumerable.Range(1, 100).Select(i =>
            {
                var origem = $"Origem {i}";
                var destino = $"Destino {i}";

                return new Voo
                {
                    Id = Guid.NewGuid(),
                    Origem = origem,
                    Destino = destino,
                    DataHoraDePartida = DateTime.Now.AddDays(random.Next(1, 30)),
                    DataHoraDeChegada = DateTime.Now.AddDays(random.Next(1, 30)),
                    Tipo = TipoDeClasses.Economica,
                    QuantidadeDosAssentos = random.Next(22, 50),
                    ValorDoAssento = random.Next(500, 5000)
                };
            }).ToList();

            modelBuilder.Entity<Voo>().HasData(voos);
        }
    }
    }
