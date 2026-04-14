using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class RegistroEntradaService 
{

  private readonly IVeiculoRepository _repository;


  public RegistroEntradaService(IVeiculoRepository repository)
  {

    _repository = repository;

  }

  public async Task Executar(string placa)
  {

    if(string.IsNullOrEmpty(placa)) throw new ArgumentException("Placa invalida");

    var veiculo = new Veiculo {Placa = placa, HoraEntrada = DateTime.Now};

    await _repository.Salvar(veiculo);
    Console.WriteLine($"Veiculo {placa} registrado com sucesso {DateTime.Now}");
  }
}