using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Repository;
using LocadoraVeiculo.Services.Infrastructure;
/// Quando instanciar a classe referida, "alt + enter", aplicara o using referida...
using System;

namespace LocadoraVeiculo.Services
{
    public class ContratoService
    {
        ContratoRepository contratoRepository = new ContratoRepository(); // Instância de uma classe...(objeto)
        FranquiaContratoRepository franquiaContratoRepository = new FranquiaContratoRepository();

        public void Insert(string placa, int idCliente, DateTime dataPrevistaDevolucao)
        {
            Contrato contrato = new Contrato();
            contrato.Numero = RetornarNumeroNovoContrato();
            contrato.Placa = placa;
            contrato.IdCliente = idCliente;
            contrato.DataContratacao = DateTime.Now;
            contrato.DataPrevistaDevolucao = dataPrevistaDevolucao;
            contrato.Valor = RetornarValorContrato(contrato.DataContratacao, contrato.DataPrevistaDevolucao);

            contratoRepository.Insert(contrato);
        }
        public void AlterarPrevisaoFechamento (string numero, DateTime dataContrato, DateTime dataPrevistaDevolucao)
        {
            decimal valor = RetornarValorContrato(dataContrato, dataPrevistaDevolucao);
            contratoRepository.AlterarPrevisaoFechamento(numero, dataPrevistaDevolucao, valor);
        }
        private decimal RetornarValorContrato(DateTime dataContrato, DateTime dataPrevistaDevolucao)
        {
            int diasContrato = dataPrevistaDevolucao.Subtract(dataContrato).Days;
            return diasContrato * franquiaContratoRepository.RetornarValorFranquiaAluguel();
        }
        private string RetornarNumeroNovoContrato()
        {
            Random random = new Random();
            int num1 = random.Next(1, 26);
            int num2 = random.Next(1, 26);
            string letra1 = Util.RetLetraAlfabeto(num1);
            string letra2 = Util.RetLetraAlfabeto(num2);
            string numero = random.Next(1, 9999).ToString("0000");

            string numeroContrato = $"{DateTime.Now.Year.ToString()}{letra1}{letra2}{numero}";
            return numeroContrato;
        }
    }
}