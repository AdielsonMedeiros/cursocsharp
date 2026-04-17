using Core.Domain;
using System.Threading.Tasks;

namespace Core.Ports.Outgoing;


public interface IProdutoRepository
{
    Task<Produto?> ObterPorId(int id);
    Task Atualizar(int id, int quantidade);
}


