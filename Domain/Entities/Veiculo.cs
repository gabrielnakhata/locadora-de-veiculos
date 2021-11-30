using System.Collections.Generic;

namespace Domain.Entities
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Codigo_categoria { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}
