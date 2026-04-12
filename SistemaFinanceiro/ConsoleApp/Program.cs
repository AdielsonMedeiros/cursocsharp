using Domain;
using Domain.Models;
using Domain.Interfaces;


var carteira = new Carteira();

var petrobras = new Acao("Petrobras", 100, DateTime.Now, "PETR4", 120);
var cdbInter = new Acao("Vale", 200, DateTime.Now, "VALE3", 150);

carteira.AdicionarAtivo(petrobras);
carteira.AdicionarAtivo(cdbInter);

Console.WriteLine($"Saldo Total: {carteira.CalcularSaldoTotal()}");
Console.WriteLine($"Lucro Total: {carteira.CalcularLucroTotal()}");



Console.WriteLine("== Relatorio ===");
foreach (var ativo in carteira.Ativos)
{
    var nome = (ativo as AtivoBase)?.Nome ?? "Ativo Desconhecido";
    Console.WriteLine($"Nome: {nome} | Lucro: {ativo.CalcularRendimento():C2}");

}
Console.WriteLine("------------------------------");
Console.WriteLine($"Saldo Total: {carteira.CalcularSaldoTotal():C2}");
Console.WriteLine($"Lucro Total: {carteira.CalcularLucroTotal():C2}");