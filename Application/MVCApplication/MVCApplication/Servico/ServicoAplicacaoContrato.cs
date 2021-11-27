using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Servico
{
    public class ServicoAplicacaoContrato : IServicoAplicacaoContrato
    {
        // readonly, Em uma declaração de campo, indica que a atribuição ao campo só pode ocorrer como
        // parte da declaração ou em um construtor na mesma readonly classe.

        private readonly IContratoService ContratoService; 

        public ServicoAplicacaoContrato(IContratoService contratoService)
        {
            ContratoService = contratoService;
        }

        public void Cadastrar(ContratoViewModel contrato)
        {
            Contrato item = new()
            {
                Numero = contrato.Numero.ToString(),
                Placa = contrato.Placa.ToString(),
                IdCliente = contrato.IdCliente,
                Data = contrato.Data,
                DataPrevisaoDevolucao = contrato.DataPrevisaoDevolucao,
                DataDevolucao = contrato.DataDevolucao,
                Valor = contrato.Valor
            };

            ContratoService.Cadastrar(item);
        }

        public ContratoViewModel CarregarRegistro(int IdCliente)
        {
            var registro = ContratoService.CarregarRegistro(IdCliente);

            ContratoViewModel contrato = new()
            { 
                Numero = registro.Numero.ToString(),
                Placa = registro.Placa.ToString(),
                IdCliente = registro.IdCliente,
                Data = registro.Data,
                DataPrevisaoDevolucao = registro.DataPrevisaoDevolucao,
                DataDevolucao = registro.DataDevolucao,
                Valor = registro.Valor
            };

            return contrato;
        }

        public void Excluir(int id)
        {
            ContratoService.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaContratosDropDownList()
        {
            var lista = this.Listagem();
            List<SelectListItem> retorno = new();

            foreach (var item in lista)
            {
                SelectListItem contrato = new()
                {
                    Value = item.IdCliente.ToString(),
                    Text = item.Placa
                };
                retorno.Add(contrato); 
            }

            return retorno;
        }

        public IEnumerable<ContratoViewModel> Listagem()
        {
            var lista = ContratoService.Listagem();
            List<ContratoViewModel> listaContratos = new();

            foreach (var item in lista)
            {
                ContratoViewModel contrato = new()
                {
                    Numero = item.Numero.ToString(),
                    Placa = item.Placa.ToString(),
                    IdCliente = item.IdCliente,
                    Data = item.Data,
                    DataPrevisaoDevolucao = item.DataPrevisaoDevolucao,
                    DataDevolucao = item.DataDevolucao,
                    Valor = item.Valor
                };
                listaContratos.Add(contrato);
            }

            return listaContratos;
        }
    
    }
}
