using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IContratoRepository
    {
        public void RegistrarContrato(Contrato contrato);
        public void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor);
        public void Delete(string id);
        public IEnumerable<Contrato> List(int? id);
    }
}
