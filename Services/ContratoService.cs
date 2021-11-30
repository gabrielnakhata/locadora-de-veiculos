using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ContratoService : IContratoService
    {

        IContratoRepository ContratoRepository;

        public ContratoService(IContratoRepository contratoRepository)
        {
            ContratoRepository = contratoRepository;        
        }

        public void Atualizar(Contrato contrato)
        {

            ContratoRepository.AlterarPrevisaoFechamento(contrato.Numero.ToString(), contrato.DataPrevisaoDevolucao, contrato.Valor);
        }

        public void Cadastrar(Contrato contrato)
        {
            ContratoRepository.RegistrarContrato(contrato);
        }

        public Contrato CarregarRegistro(string id)
        {
            return ContratoRepository.List(id.ToString()).FirstOrDefault();
        }

        public void Excluir(string id)
        {
            ContratoRepository.Delete(id.ToString()); 
        }

        public IEnumerable<Contrato> Listagem()
        {
            return ContratoRepository.List(null);
        }


        //public void AlterarPrevisaoFechamento (string numero, DateTime dataContrato, DateTime dataPrevistaDevolucao)
        //{
        //    decimal valor = RetornarValorContrato(dataContrato, dataPrevistaDevolucao);
        //    ContratoRepository.AlterarPrevisaoFechamento(numero, dataPrevistaDevolucao, valor);
        //}
        //private decimal RetornarValorContrato(DateTime dataContrato, DateTime dataPrevistaDevolucao)
        //{
        //    int diasContrato = dataPrevistaDevolucao.Subtract(dataContrato).Days;
        //    return diasContrato * FranquiaContratoRepository.RetornarValorFranquiaAluguel();
        //}
        //private string RetornarNumeroNovoContrato()
        //{
        //    Random random = new Random();
        //    int num1 = random.Next(1, 26);
        //    int num2 = random.Next(1, 26);
        //    string letra1 = Util.RetLetraAlfabeto(num1);
        //    string letra2 = Util.RetLetraAlfabeto(num2);
        //    string numero = random.Next(1, 9999).ToString("0000");

        //    string numeroContrato = $"{DateTime.Now.Year}{letra1}{letra2}{numero}";
        //    return numeroContrato;
        //}
    }
}