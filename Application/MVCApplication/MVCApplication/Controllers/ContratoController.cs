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
        readonly IServicoAplicacaoCliente ServicoAplicacaoCliente;

        public ContratoController(
            IServicoAplicacaoContrato servicoAplicacaoContrato,
            IServicoAplicacaoCliente servicoAplicacaoCliente)
        {
            ServicoAplicacaoContrato = servicoAplicacaoContrato;
            ServicoAplicacaoCliente = servicoAplicacaoCliente;

        }
        public IActionResult Index()
        {
            return View(ServicoAplicacaoContrato.Listagem());
        }

        [HttpGet]

        public IActionResult Cadastro(string id)
        {

            ContratoViewModel viewModel = new();

            if (id != null)
            {
                viewModel = ServicoAplicacaoContrato.CarregarRegistro(id);
            }
            else
                viewModel.Numero = ServicoAplicacaoContrato.ObterNumeroContrato();

            viewModel.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();

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
                entidade.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Excluir(string id)
        {
            ServicoAplicacaoContrato.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
