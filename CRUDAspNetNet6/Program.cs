using CRUDAspNetNet6.Data;
using CRUDAspNetNet6.Repositories;
using CRUDAspNetNet6.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//comando usados quando usa o EntityFramework
//Context Adicionado.
builder.Services.AddDbContext<SistemaDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseDefault")));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

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

app.Run();
