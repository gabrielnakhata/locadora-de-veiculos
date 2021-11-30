using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ClienteService : IClienteService
    {
        IClienteRepository ClienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository;
        }
        public void Atualizar(Cliente cliente)
        {
            ClienteRepository.Update(cliente);
        }

        public void Cadastrar(Cliente cliente)
        {
            ClienteRepository.Create(cliente);
        }

        public Cliente CarregarRegistro(string id)
        {
            return ClienteRepository.List(id).FirstOrDefault();
        }

        public void Excluir(string id)
        {
            ClienteRepository.Delete(id.ToString());
        }

        public IEnumerable<Cliente> Listagem()
        {
            return ClienteRepository.List(null);
        }
    }
}
