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
    public class ServicoAplicacaoVeiculo : IServicoAplicacaoVeiculo
    {
        private readonly IVeiculoService VeiculoService;

        public ServicoAplicacaoVeiculo(IVeiculoService veiculoService)
        {
            VeiculoService = veiculoService;
        }
        public void Cadastrar(VeiculoViewModel veiculo)
        {
            Veiculo item = new()
            {
                Placa = veiculo.Placa,
                Ano = veiculo.Ano,
                Marca = veiculo.Marca,
                Modelo = veiculo.Modelo,
                Codigo_categoria = veiculo.Codigo_categoria
            };

            if (veiculo.Placa == null)
                VeiculoService.Cadastrar(item);
            else
                VeiculoService.Atualizar(item);
        }

        public VeiculoViewModel CarregarRegistro(string codigoVeiculo)
        {
            var registro = VeiculoService.CarregarRegistro(codigoVeiculo);

            VeiculoViewModel veiculo = new()
            { 
                Placa = registro.Placa,
                Ano = registro.Ano,
                Marca = registro.Marca,
                Modelo = registro.Modelo,
                Codigo_categoria = registro.Codigo_categoria
            };

            return veiculo;

        }

        public void Excluir(string id)
        {
            VeiculoService.Excluir(id);
        }

        public IEnumerable<VeiculoViewModel> Listagem()
        {
            var lista = VeiculoService.Listagem();
            List<VeiculoViewModel> listaVeiculos = new ();
            foreach (var item in lista)
            {
                VeiculoViewModel veiculo = new ()
                {
                    Placa = item.Placa,
                    Ano = item.Ano,
                    Marca = item.Marca,
                    Modelo = item.Modelo,
                    Codigo_categoria = item.Codigo_categoria
                };
                listaVeiculos.Add(veiculo);

            }

            return listaVeiculos;
        }

        public IEnumerable<SelectListItem> ListaVeiculosDropDownList()
        {
            List<SelectListItem> retorno = new ();
            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem veiculo = new ()
                {
                    Value = item.Placa.ToString(),
                    Text = item.Marca
                };
                retorno.Add(veiculo);
            }
            return retorno;
        }
    }
}
