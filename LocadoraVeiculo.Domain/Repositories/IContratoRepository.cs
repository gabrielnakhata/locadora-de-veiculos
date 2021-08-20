using LocadoraVeiculo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculo.Domain.Repositories
{
    public interface IContratoRepository
    {
        void Insert(Contrato contrato);
        void Update(Contrato contrato);
    }
}
