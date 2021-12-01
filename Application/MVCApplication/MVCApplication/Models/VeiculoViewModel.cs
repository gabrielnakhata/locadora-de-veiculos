using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class VeiculoViewModel
    {
        [Required(ErrorMessage = "Informe a placa do veículo!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe o ano do veículo!")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Informe a marca do veículo!")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Informe o modelo do veículo!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Informe a categoria do produto!")]
        public int Codigo_categoria { get; set; }
        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
        public string DescricaoCategoria { get; set; }

    }
}
