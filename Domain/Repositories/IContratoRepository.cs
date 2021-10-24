using Domain.Entities;
using System;

namespace Domain.Repositories
{
    public interface IContratoRepository : IRepository<Contrato>
    {
        void RegistrarContrato(Contrato contrato);
        void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor);
    }
}
