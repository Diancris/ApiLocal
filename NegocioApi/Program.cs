using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using NegocioApi.IServices;
using NegocioApi.Services;
using Microsoft.EntityFrameworkCore;
using Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IUserLogic, UserLogic>();


builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserServices, UserService>();


builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

var app = builder.Build();

//var newProduct = new ProductItem();
//newProduct.AuthorName = "Producto de prueba";




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
