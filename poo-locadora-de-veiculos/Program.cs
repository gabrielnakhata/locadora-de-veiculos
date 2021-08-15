using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Services;
using System;

namespace poo_locadora_de_veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService clienteService = new ClienteService();

            Cliente cliente = new Cliente();
            cliente.Nome = "Charlie";
            cliente.Email = "charlieman@gmail.com";
            cliente.Cpf = "3029920";
            cliente.Cnh = "392203";
            cliente.Celular = "31988829";

            clienteService.Inserir(cliente);
            
        }
    }
}
