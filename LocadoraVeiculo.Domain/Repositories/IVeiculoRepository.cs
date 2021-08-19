using LocadoraVeiculo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculo.Domain.Repositories
{
    public interface IVeiculoRepository
    {
        void Insert(Veiculo veiculo);
        void Update(Veiculo veiculo);
        void Delete(Veiculo veiculo);

    }

}
