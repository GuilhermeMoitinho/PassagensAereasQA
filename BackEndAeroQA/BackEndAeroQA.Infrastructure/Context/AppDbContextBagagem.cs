using BackEndAeroQA.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class AppDbContextBagagem : DbContext
    {

        public AppDbContextBagagem(DbContextOptions<AppDbContextBagagem> op) : base(op)
        {
        }

        public DbSet<Bagagem> Bagagens { get; set; }
    }
}
