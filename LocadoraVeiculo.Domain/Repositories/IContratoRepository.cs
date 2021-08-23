using LocadoraVeiculo.Domain.Entities;
using System;

namespace LocadoraVeiculo.Domain.Repositories
{
    public interface IContratoRepository
    {
        void RegistrarContrato(Contrato contrato);
        void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor);


    }
}
