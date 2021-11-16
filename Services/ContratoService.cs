using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ContratoService : IContratoService
    {

        IContratoRepository ContratoRepository;

        public ContratoService(IContratoRepository contratoRepository)
        {
            ContratoRepository = contratoRepository;        
        }
        public void Atualizar(Contrato entidade)
        {
            ContratoRepository.AlterarPrevisaoFechamento(entidade);
        }

        public void Cadastrar(Contrato entidade)
        {
            ContratoRepository.RegistrarContrato(entidade);
        }
       
        public Contrato CarregarRegistro(int id)
        {
            return ContratoRepository.Read(id);
        }
        public void Excluir(int id)
        {
            ContratoRepository.Delete(id);
        }
        public IEnumerable<Contrato> Listagem()
        {
            return ContratoRepository.Read();
        }

        //public void RegistrarContrato(string placa, int idCliente, DateTime dataPrevistaDevolucao)
        //{
        //    Contrato contrato = new Contrato();
        //    contrato.Numero = RetornarNumeroNovoContrato();
        //    contrato.Placa = placa;
        //    contrato.IdCliente = idCliente;
        //    contrato.DataContratacao = DateTime.Now;
        //    contrato.DataPrevistaDevolucao = dataPrevistaDevolucao;
        //    contrato.Valor = RetornarValorContrato(contrato.DataContratacao, contrato.DataPrevistaDevolucao);

        //    ContratoRepository.RegistrarContrato(contrato);
        //}
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