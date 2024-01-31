using BackEndAeroQA.Application.Auth;
using BackEndAeroQA.Application.Interfaces;
using BackEndAeroQA.Application.Services;
using BackEndAeroQA.Applicaton.Interfaces;
using BackEndAeroQA.Infrastructure.Context;
using BackEndAeroQA.WebAPI.Configuracoes;
using BackEndAeroQA.WebAPI.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddRegisteredServices(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthanticationJwt();
builder.Services.AddSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
             .AllowAnyOrigin() 
             .AllowAnyMethod() 
             .AllowAnyHeader()) 
             .UseAuthentication();


app.UseAuthorization();

app.MapControllers();

app.Run();
