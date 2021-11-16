using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Controllers
{
    public class ContratoController : Controller
    {
        readonly IServicoAplicacaoContrato ServicoAplicacaoContrato;

        public ContratoController(IServicoAplicacaoContrato servicoAplicacaoContrato)
        {
            ServicoAplicacaoContrato = servicoAplicacaoContrato;
        }
        public IActionResult Index()
        {
            return View(ServicoAplicacaoContrato.Listagem());
        }

        [HttpGet]

        public IActionResult Cadastro(int? id)
        {

            ContratoViewModel viewModel = new();

            if (id != null)
            {
                viewModel = ServicoAplicacaoContrato.CarregarRegistro((int)id);
            }
            return View(viewModel);
        }

        [HttpPost] 

        public IActionResult Cadastro(ContratoViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoContrato.Cadastrar(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Excluir(int id)
        {
            ServicoAplicacaoContrato.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
