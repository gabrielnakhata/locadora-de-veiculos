using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class ClienteViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente!")]
        [MinLength(11, ErrorMessage ="O CPF deve ter 11 dígitos...")]
        [MaxLength(11, ErrorMessage ="O CPF deve ter 11 dígitos...")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o E-mail do cliente!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o celular do cliente!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe a CNH do cliente!")]
        public string Cnh { get; set; }

    }

}
