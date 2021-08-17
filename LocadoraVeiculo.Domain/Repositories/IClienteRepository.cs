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
        /// Operação de inserção de um cliente no DB...
        /// </summary>
        /// <param name="cliente">Objeto da entidade Cliente...</param>
        void Insert(Cliente cliente);

        /// <summary>
        /// Operação de update de um cliente no DB...
        /// </summary>
        /// <param name="cliente">Objeto da entidade Cliente...</param>
        void Update(Cliente cliente);

        /// <summary>
        /// Operação de delete de um cliente no DB...
        /// </summary>
        /// <param name="id">Número int definido para exclusão do Cliente no DB pela chave primária a Id...</param>
        void Delete(int id);

        

        
    }
}
