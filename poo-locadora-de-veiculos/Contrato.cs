using System;
using System.Collections.Generic;
using System.Text;

namespace poo_locadora_de_veiculos
{
    public class Contrato
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataContratacao {get; set;}
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; set; }

    }
}
