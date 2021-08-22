using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Services;
using System;

namespace poo_locadora_de_veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // "CTRL + K + C" = Comentar um Bloco selecionando...
            // "CTRL + K + U" = Descomentar um Bloco selecionando...

            // -------------------------------------------------------------------------------- //

            //ClienteService clienteService = new ClienteService();
            //Cliente cliente = new Cliente();

            //Console.WriteLine("Para [Insert] em cliente precione [Enter] ... ");
            //Console.ReadKey();

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

            // -------------------------------------------------------------------------------- //

            //Console.WriteLine("Para [Update] em veículo precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite o id do cliente...");
            //cliente.Numero = int.Parse(Console.ReadLine());
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

            // -------------------------------------------------------------------------------- //

            //Console.WriteLine("Para [Delete] em cliente precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite o id do cliente que deseja deletar...");
            //int idExclusao = int.Parse(Console.ReadLine());

            //clienteService.Delete(idExclusao);

            // -------------------------------------------------------------------------------- //

            //VeiculoService veiculoService = new VeiculoService();
            //Veiculo veiculo = new Veiculo();

            //Console.WriteLine("Para [Insert] em veículo precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite a placa do veículo...");
            //veiculo.Placa = Console.ReadLine();
            //Console.WriteLine("Digite a ano do veículo...");
            //veiculo.Ano = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a marca do veículo...");
            //veiculo.Marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do veículo...");
            //veiculo.Modelo = Console.ReadLine();

            //veiculoService.Insert(veiculo);

            // -------------------------------------------------------------------------------- //

            //Console.WriteLine("Para [Update] em veículo precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite a placa do veículo...");
            //veiculo.Placa = Console.ReadLine();
            //Console.WriteLine("Digite a ano do veículo...");
            //veiculo.Ano = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a marca do veículo...");
            //veiculo.Marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do veículo...");
            //veiculo.Modelo = Console.ReadLine();

            //veiculoService.Update(veiculo);

            // -------------------------------------------------------------------------------- //

            //Console.WriteLine("Para [Delete] em veículo precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite a placa do veículo que deseja deletar...");
            //string placa = Console.ReadLine();

            //veiculoService.Delete(placa);

            // -------------------------------------------------------------------------------- //

            ContratoService contratoService = new ContratoService();
            Contrato contrato = new Contrato();

            Console.WriteLine("para [insert] em contrato precione [enter] ... ");
            Console.ReadKey();

            Console.WriteLine("digite a placa...");
            string placa = Console.ReadLine();
            Console.WriteLine("digite o id do cliente...");
            int idCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a data prevista para devolução...");
            DateTime dataPrevistaDevolucao = DateTime.Parse(Console.ReadLine());

            contratoService.Insert(placa, idCliente, dataPrevistaDevolucao);

            // -------------------------------------------------------------------------------- //

            //Console.WriteLine("Para [Update] em contrato precione [Enter] ... ");
            //Console.ReadKey();

            //Console.WriteLine("Digite o número do contrato...");
            //string numero = Console.ReadLine();
            //Console.WriteLine("Digite a Data do contrato...");
            //DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a data prevista para devolução...");
            //DateTime dataPrevistaDevolucao = DateTime.Parse(Console.ReadLine());

            //contratoService.AlterarPrevisaoFechamento(numero, dataContrato, dataPrevistaDevolucao);
        }
    }
}

