using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IVeiculoRepository
    {
        void Insert(Veiculo veiculo);
        void Update(Veiculo veiculo);
        void Delete(string placa);
        public IEnumerable<Veiculo> List(int? id);
    }
}
