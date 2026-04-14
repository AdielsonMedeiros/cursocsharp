using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;

IVeiculoRepository repo = new VeiculoRepository();

var service = new RegistroEntradaService(repo);

await service.Executar("BRA-1234");
