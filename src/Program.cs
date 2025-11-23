using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

Console.WriteLine("Launcher rodando com sucesso na porta 5000");
Console.WriteLine("Acesse: http://localhost:5000");

app.UseRouting();
app.MapDefaultControllerRoute();

app.Run("http://localhost:5000");