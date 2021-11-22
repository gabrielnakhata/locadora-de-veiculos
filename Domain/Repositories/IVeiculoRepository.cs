using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVeiculoRepository
    {
        void Insert(Veiculo veiculo);
        void Update(Veiculo veiculo);
        void Delete(string placa);
    }
}
