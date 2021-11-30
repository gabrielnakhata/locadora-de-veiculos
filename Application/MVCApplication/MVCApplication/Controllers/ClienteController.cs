
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.Servico.Interfaces;


namespace MVCApplication.Controllers
{
    public class ClienteController : Controller
    {

        readonly IServicoAplicacaoCliente ServicoAplicacaoCliente;

        public ClienteController(IServicoAplicacaoCliente servicoAplicacaoCliente) 
        {
            ServicoAplicacaoCliente = servicoAplicacaoCliente;
        }
        public IActionResult Index()
        {
            return View(ServicoAplicacaoCliente.Listagem());
        }

        [HttpGet] // Atributo, decora uma função, procedimento ou classe determinando seu comportamento...
        public IActionResult Cadastro(string id) // O operador "?", indica que a avariável é anulável, ou seja, pode receber valor "null".
        {
            ClienteViewModel viewModel = new();

            if (id != null)
            {
                viewModel = ServicoAplicacaoCliente.CarregarRegistro(id);
            }
            return View(viewModel);
        }

        [HttpPost] // 
        public IActionResult Cadastro(ClienteViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoCliente.Cadastrar(entidade);
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
            ServicoAplicacaoCliente.Excluir(id.ToString());
            return RedirectToAction("Index");
        }
    }
}
