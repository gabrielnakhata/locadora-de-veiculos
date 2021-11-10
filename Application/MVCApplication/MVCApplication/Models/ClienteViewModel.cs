using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class ClienteViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o E-mail do cliente!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o celular do cliente!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe a CNH do cliente!")]
        public string Cnh { get; set; }
    }
}
