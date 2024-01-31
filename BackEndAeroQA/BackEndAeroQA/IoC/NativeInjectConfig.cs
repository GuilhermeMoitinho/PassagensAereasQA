using BackEndAeroQA.Application.Auth;
using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.Services;
using BackEndAeroQA.Applicaton.Interfaces;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndAeroQA.WebAPI.IoC
{
    public static class NativeInjectConfig
    {
        public static void AddRegisteredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<DbContextAeroporto>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<DbContextVoo>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<AppDbContextVoucher>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<AppDbContextBagagem>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<AppDbContextUsuario>
                    (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));



            services.AddScoped<IVooService, VooService>();
            services.AddScoped<IAeroportoService, AeroportoService>();
            services.AddScoped<IPassageiroService, PassageiroService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<TokenService>();
        }
    }
}