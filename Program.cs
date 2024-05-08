using Juliana_Sosa_API_Burger.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Juliana_Sosa_API_Burger.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Juliana_Sosa_API_BurgerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Juliana_Sosa_API_BurgerContext") ?? throw new InvalidOperationException("Connection string 'Juliana_Sosa_API_BurgerContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapBurgerEndpoints();

app.Run();
