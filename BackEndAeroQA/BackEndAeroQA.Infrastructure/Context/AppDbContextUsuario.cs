using BackEndAeroQA.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class AppDbContextUsuario : DbContext
    {
        public AppDbContextUsuario(DbContextOptions<AppDbContextUsuario> op) : base(op) 
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
