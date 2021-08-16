using LocadoraVeiculo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculo.Domain.Repositories
{
    /// <summary>
    /// Contrato que estabelece as operações que deverão ser implementadas pela camada de Repository
    /// </summary>
    public interface IClienteRepository
    {
        /// <summary>
        /// Operação de inserção de um cliente no DB
        /// </summary>
        /// <param name="cliente">Objeto da entidade Cliente</param>
        void Insert(Cliente cliente);

        void Update(Cliente cliente);
        
    }
}
