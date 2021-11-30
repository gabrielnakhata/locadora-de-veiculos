using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Contrato
    {
        public string Numero { get; set; }
        public string Placa { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data {get; set;}
        public DateTime DataPrevisaoDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; }


    }
}
