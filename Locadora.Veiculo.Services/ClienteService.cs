using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Repository;
using System;

namespace LocadoraVeiculo.Services
{
    public class ClienteService
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public void Inserir(Cliente cliente)
        {
            clienteRepository.Inserir(cliente);
        }
    }
}
