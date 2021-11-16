using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class ContratoViewModel
    {
        public string Numero { get; set; }

        [Required(ErrorMessage = "Informe a placa do veículo!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe o Id do cliente!")]
        public int IdCliente { get; set; }
        
        [Required(ErrorMessage = "Informe a Data da contratação!")]
        public DateTime DataContratacao { get; set; }

        [Required(ErrorMessage = "Informe a Data prevista para devolução!")]
        public DateTime DataPrevistaDevolucao { get; set; }

        [Required(ErrorMessage = "Informe a Data prevista para devolução!")]
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; set; }
        public IEnumerable<SelectListItem> ListaClientes { get; set; }
        public IEnumerable<SelectListItem> ListaPlacasVeiculos { get; set; }

    }
}
