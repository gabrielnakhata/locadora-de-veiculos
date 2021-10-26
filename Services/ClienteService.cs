using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Repository;
using System.Collections.Generic;

namespace Services
{
    public class ClienteService : IClienteService
    {
        IClienteRepository ClienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository;
        }

        public void Cadastrar(Cliente cliente)
        {
            ClienteRepository.Create(cliente);
        }

        public Cliente CarregarRegistro(int id)
        {
            return ClienteRepository.Read(id);
        }

        public void Excluir(int id)
        {
            ClienteRepository.Delete(id);
        }

        public IEnumerable<Cliente> Listagem()
        {
            return ClienteRepository.Read();
        }
    }
}
