using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class VeiculoService : IVeiculoService
    {
        IVeiculoRepository VeiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            VeiculoRepository = veiculoRepository;
        }
        public void Atualizar(Veiculo veiculo)
        {
            VeiculoRepository.Update(veiculo);
        }

        public void Cadastrar(Veiculo veiculo)
        {
            VeiculoRepository.Insert(veiculo);
        }

        public Veiculo CarregarRegistro(string id)
        {
            return VeiculoRepository.List(id.ToString()).FirstOrDefault();
        }

        public void Excluir(string id)
        {
            VeiculoRepository.Delete(id.ToString());
        }

        public IEnumerable<Veiculo> Listagem()
        {
            return VeiculoRepository.List(null);
        }

    }
}
