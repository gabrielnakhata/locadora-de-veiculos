using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Controllers
{
    public class CategoriaController : Controller
    {
        readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public CategoriaController(IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }
        public IActionResult Index()
        {
            return View(ServicoAplicacaoCategoria.Listagem());
        }

        [HttpGet] // Atributo, decora uma função, procedimento ou classe determinando seu comportamento...
        public IActionResult Cadastro(string id) // O operador "?", indica que a avariável é anulável, ou seja, pode receber valor "null".
        {
            CategoriaViewModel viewModel = new();

            if (id != null)
            {
                viewModel = ServicoAplicacaoCategoria.CarregarRegistro(id);
            }
            return View(viewModel);
        }

        [HttpPost] // 
        public IActionResult Cadastro(CategoriaViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoCategoria.Cadastrar(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Excluir(string id)
        {
            ServicoAplicacaoCategoria.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
