using Domain.Entities;
using Repository;

namespace Services
{
    public class VeiculoService
    {
        VeiculoRepository veiculoRepository = new VeiculoRepository();

        public void Insert(Veiculo veiculo)
        {
            veiculoRepository.Insert(veiculo);
        }
        public void Update(Veiculo veiculo)
        {
            veiculoRepository.Update(veiculo);
        }
        public void Delete(string placa)
        {
            veiculoRepository.Delete(placa);
        }
    }
}
