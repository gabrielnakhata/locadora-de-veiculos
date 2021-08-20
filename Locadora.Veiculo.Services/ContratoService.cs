using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Repository; /// Quando instanciar a classe referida, "alt + enter", aplicara o using referida...
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculo.Services
{
    public class ContratoService
    {
        ContratoRepository contratoRepository = new ContratoRepository(); // Instância de uma classe...(objeto)
        public void Insert(Contrato contrato)
        {
            contratoRepository.Insert(contrato);
        }
        public void Update(Contrato contrato)
        {
            contratoRepository.Update(contrato);
        }
    }
}
