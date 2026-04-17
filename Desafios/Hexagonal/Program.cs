using Adapters.Driven;
using Core.Ports.Incoming;
using Core.Services;
using Core.Ports.Outgoing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;





var services = new ServiceCollection();

services.AddDbContext<EstoqueDbContext>();
services.AddScoped<IProdutoRepository, SqliteAdapter>();
services.AddScoped<IEstoqueService, EstoqueManager>();


var provider = services.BuildServiceProvider();
var app = provider.GetRequiredService<IEstoqueService>();

Console.WriteLine("Iniciando sistema");
await app.ExecutarMovimentacao(1, -5);
Console.WriteLine("Movimentação realizada com sucesso");



