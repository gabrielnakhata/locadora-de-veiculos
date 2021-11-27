﻿using System;

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
    }
}
