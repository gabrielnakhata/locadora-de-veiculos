using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Repository;
using System;

namespace LocadoraVeiculo.Services
{
    public class ClienteService
    {
        ClienteRepository clienteRepository = new ClienteRepository(); // Instância de uma classe...(objeto)

        public void Insert(Cliente cliente) // procedimento na camada de serviço, para inserir um cliente
        {
            clienteRepository.Insert(cliente);
        }

        public void Update(Cliente cliente)
        {
            clienteRepository.Update(cliente);  
        }

        public void Delete(int id)
        {
            clienteRepository.Delete(id);
        }
    }
}
