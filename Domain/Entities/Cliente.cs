using System.Collections.Generic;

namespace Domain.Entities
{ 
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cnh { get; set; }

        public ICollection<Contrato> Contratos { get; set; }
    }
}
