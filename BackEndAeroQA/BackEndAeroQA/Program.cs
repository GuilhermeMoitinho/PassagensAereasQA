using BackEndAeroQA.Application.Validacoes;
using BackEndAeroQA.WebAPI.Configuracoes;
using BackEndAeroQA.WebAPI.IoC;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation((fv => fv.RegisterValidatorsFromAssemblyContaining<VooValidacao>()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddRegisteredServices(builder.Configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
