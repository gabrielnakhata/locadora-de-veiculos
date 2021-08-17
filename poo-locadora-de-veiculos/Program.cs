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

            // "CTRL + K + C" = Comentar um Bloco selecionando...
            // "CTRL + K + U" = Descomentar um Bloco selecionando...

            //Cliente cliente = new Cliente();
            //Console.WriteLine("Digite o nome do cliente...");
            //cliente.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o E-mail...");
            //cliente.Email = Console.ReadLine();
            //Console.WriteLine("Digite o CPF...");
            //cliente.Cpf = Console.ReadLine();
            //Console.WriteLine("Digite a CNH...");
            //cliente.Cnh = Console.ReadLine();
            //Console.WriteLine("Digite o celular...");
            //cliente.Celular = Console.ReadLine();

            //clienteService.Insert(cliente);

            //Cliente cliente = new Cliente();

            //Console.WriteLine("Digite o id do cliente...");
            //cliente.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do cliente...");
            //cliente.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o E-mail...");
            //cliente.Email = Console.ReadLine();
            //Console.WriteLine("Digite o CPF...");
            //cliente.Cpf = Console.ReadLine();
            //Console.WriteLine("Digite a CNH...");
            //cliente.Cnh = Console.ReadLine();
            //Console.WriteLine("Digite o celular...");
            //cliente.Celular = Console.ReadLine();

            //clienteService.Update(cliente);


            Console.WriteLine("Digite o id do cliente que deseja deletar...");
            int idExclusao = int.Parse(Console.ReadLine());

            clienteService.Delete(idExclusao);



        }
    }
}
