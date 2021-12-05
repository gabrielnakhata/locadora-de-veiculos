
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Controllers
{
    public class VeiculoController : Controller
    {
        readonly IServicoAplicacaoVeiculo ServicoAplicacaoVeiculo;

        public VeiculoController(IServicoAplicacaoVeiculo servicoAplicacaoVeiculo)
        {
            ServicoAplicacaoVeiculo = servicoAplicacaoVeiculo;
        }
        public IActionResult Index()
        {
            return View(ServicoAplicacaoVeiculo.Listagem());
        }

        [HttpGet] 
        public IActionResult Cadastro(string id) 
        {
            VeiculoViewModel viewModel = new();
           

            if (id != null)
            {
                viewModel = ServicoAplicacaoVeiculo.CarregarRegistro(id);
            }

            viewModel.ListaCategorias = ServicoAplicacaoVeiculo.ListaCategoriaDropDownList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(VeiculoViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoVeiculo.Cadastrar(entidade);
            }
            else
            {
                entidade.ListaCategorias = ServicoAplicacaoVeiculo.ListaCategoriaDropDownList();
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Excluir(string id)
        {
            ServicoAplicacaoVeiculo.Excluir(id.ToString());
            return RedirectToAction("Index");
        }
    }
}
