using System;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class VeiculoRepository : IVeiculoRepository
{
    public Task Salvar(Veiculo veiculo)
    {
        Console.WriteLine($"Veiculo {veiculo.Placa} , salvo com sucesso");
        return Task.CompletedTask;
    }
}