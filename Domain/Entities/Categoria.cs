using System.Collections.Generic;

namespace Domain.Entities
{
    public class Categoria
    {
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public ICollection<Veiculo> Modelos { get; set; }
    }
}
