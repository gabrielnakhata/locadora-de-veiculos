using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;

namespace Repository
{
    public class VeiculoRepository : Repository, IVeiculoRepository
    {
        public void Insert(Veiculo veiculo)
        {

            string sql = $"insert into veiculo(placa, ano, marca, modelo) values(" +
                         $"'{veiculo.Placa}', " +
                         $"'{veiculo.Ano}', " +
                         $"'{veiculo.Marca}', " +
                         $"'{veiculo.Modelo}')";

            ExecuteCommand(sql);

        }
        public void Update(Veiculo veiculo)
        {

            string sql = $"update veiculo set" +
                         $" ano = '{veiculo.Ano}'," +
                         $" marca = '{veiculo.Marca}'," +
                         $" modelo = '{veiculo.Modelo}'" +
                         $" where placa = '{veiculo.Placa}'";

            ExecuteCommand(sql);

        }
        public void Delete(string placa)
        {
           
            string sql = $"delete from veiculo" +
                         $" where placa = '{placa}'";

            ExecuteCommand(sql);
        }
       
    }
}
