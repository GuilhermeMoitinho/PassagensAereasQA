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

    }
}
