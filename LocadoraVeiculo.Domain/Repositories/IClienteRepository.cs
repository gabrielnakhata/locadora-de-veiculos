using LocadoraVeiculo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculo.Domain.Repositories
{
    public interface IClienteRepository
    {
        void Inserir(Cliente cliente);
    }
}
