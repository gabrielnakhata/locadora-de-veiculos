using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //private readonly IClienteService _clienteService; //DECLAREI


        //public HomeController(ILogger<HomeController> logger, IClienteService clienteService) // INJETEI
        //{
        //    _logger = logger;
        //    _clienteService = clienteService;
        //}

        public IActionResult Index()
        {
            //Cliente cliente = new Cliente()
            //{
            //    Id = 1022
            //};

            //_clienteService.Excluir(cliente.Id);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
