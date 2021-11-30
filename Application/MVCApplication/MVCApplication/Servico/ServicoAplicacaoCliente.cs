using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;
using System.Collections.Generic;

namespace MVCApplication.Servico
{
    public class ServicoAplicacaoCliente : IServicoAplicacaoCliente
    {
        private readonly IClienteService ClienteService;

        public ServicoAplicacaoCliente(IClienteService clienteService)
        {
            ClienteService = clienteService;
        }
        public void Cadastrar(ClienteViewModel cliente)
        {
            Cliente item = new()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Celular = cliente.Celular,
                Cnh = cliente.Cnh
            };

            if (cliente.Id == null)
                ClienteService.Cadastrar(item);
            else
                ClienteService.Atualizar(item);
        }

        public ClienteViewModel CarregarRegistro(string codigoCliente)
        {
            var registro = ClienteService.CarregarRegistro(codigoCliente);

            ClienteViewModel cliente = new ()
            {
                Id = registro.Id,
                Nome = registro.Nome,
                Cpf = registro.Cpf,
                Email = registro.Email,
                Celular = registro.Celular,
                Cnh = registro.Cnh
            };

            return cliente;
        }

        public void Excluir(string id)
        {
            ClienteService.Excluir(id.ToString());
        }

        public IEnumerable<SelectListItem> ListaClientesDropDownList()
        {
            List<SelectListItem> retorno = new ();
            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem cliente = new ()
                { 
                    Value = item.Id.ToString(),
                    Text = item.Nome
                };
                retorno.Add(cliente);
            }
            return retorno;
        }

        public IEnumerable<ClienteViewModel> Listagem()
        {
            var lista = ClienteService.Listagem();
            List<ClienteViewModel> listaCliente = new ();

            foreach (var item in lista)
            {
                ClienteViewModel cliente = new ()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    Email = item.Email,
                    Celular = item.Celular,
                    Cnh = item.Cnh
                };
                listaCliente.Add(cliente);
            }

            return listaCliente;
        }
    }
}
