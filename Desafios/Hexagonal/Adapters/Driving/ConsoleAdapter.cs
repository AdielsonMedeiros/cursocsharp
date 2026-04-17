using Core.Ports.Incoming;

namespace Adapters.Driving;


public class ConsoleAdapter(IEstoqueService service) : IEstoqueService
{

    public async Task ExecutarMovimentacao(int produtoId, int quantidade)
    {
        await service.ExecutarMovimentacao(produtoId, quantidade);
        
    }




}