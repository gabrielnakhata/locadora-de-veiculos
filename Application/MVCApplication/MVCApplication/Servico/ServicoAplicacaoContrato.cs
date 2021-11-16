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
                Numero = contrato.Numero,
                IdCliente = contrato.IdCliente,
                DataContratacao = contrato.DataContratacao,
                DataPrevistaDevolucao = contrato.DataPrevistaDevolucao,
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
                Numero = registro.Numero,
                IdCliente = registro.IdCliente,
                DataContratacao = registro.DataContratacao,
                DataPrevistaDevolucao = registro.DataPrevistaDevolucao,
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
            List<SelectListItem> retorno = new();
            var lista = this.Listagem();

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
                    Numero = item.Numero,
                    IdCliente = item.IdCliente,
                    DataContratacao = item.DataContratacao,
                    DataPrevistaDevolucao = item.DataPrevistaDevolucao,
                    DataDevolucao = item.DataDevolucao,
                    Valor = item.Valor
                };
                listaContratos.Add(contrato);
            }

            return listaContratos;
        }
    
    }
}
