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
    }
    }
