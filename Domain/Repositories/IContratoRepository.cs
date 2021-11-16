using Domain.Entities;
using System;

namespace Domain.Repositories
{
    public interface IContratoRepository : IRepository<Contrato>
    {
        public void RegistrarContrato(Contrato contrato);
        public void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor);
        public void Delete(int id);
        public void AlterarPrevisaoFechamento(Contrato entidade);
    }
}
