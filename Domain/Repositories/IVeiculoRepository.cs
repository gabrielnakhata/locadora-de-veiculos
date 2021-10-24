using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        void Insert(Veiculo veiculo);
        void Update(Veiculo veiculo);
        void Delete(string placa);
    }
}
