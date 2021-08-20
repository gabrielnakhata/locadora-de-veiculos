using System;

namespace LocadoraVeiculo.Domain.Entities
{
    public class Contrato
    {
        public string Id { get; set; }
        public string Placa { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataContratacao {get; set;}
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal Valor { get; set; }

    }
}
