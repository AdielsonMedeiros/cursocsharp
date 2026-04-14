using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        public Task Salvar(Veiculo veiculo);
    }
}