using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;

namespace Repository
{
    public class VeiculoRepository : Repository, IVeiculoRepository
    {
        public void Insert(Veiculo veiculo)
        {
            string sql = $"insert into veiculo(placa, ano, marca, modelo, codigo_categoria) values(" +
                        $"'{veiculo.Placa}', " +
                        $"'{veiculo.Ano}', " +
                        $"'{veiculo.Marca}', " +
                        $"'{veiculo.Modelo}', " +
                        $"'{veiculo.Codigo_categoria}')";

            ExecuteCommand(sql);
        }

        public void Update(Veiculo veiculo)
        {
            string sql = $"update veiculo set" +
                       $" ano = '{veiculo.Ano}'," +
                       $" marca = '{veiculo.Marca}'," +
                       $" modelo = '{veiculo.Modelo}'," +
                       $" codigo_categoria = '{veiculo.Codigo_categoria}'" +
                       $" where placa = '{veiculo.Placa}'";

            ExecuteCommand(sql);

        }

        public void Delete(string placa)
        {
            string sql = $"delete from veiculo" +
                         $" where placa = '{placa}'";

            ExecuteCommand(sql);
        }

        public IEnumerable<Veiculo> List(string id)
        {
            string sql = $"select ano, marca, modelo, codigo_categoria from veiculo ";
            if (id != null) { sql += $" where placa = {id}"; }

            var dataTable = Read(sql);

            List<Veiculo> listaVeiculos = new List<Veiculo>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Veiculo veiculo = new Veiculo()
                {
                    Placa = dataTable.Rows[i][0].ToString(),
                    Ano = int.Parse(dataTable.Rows[i][1].ToString()),
                    Marca = dataTable.Rows[i][2].ToString(),
                    Modelo = dataTable.Rows[i][3].ToString(),
                    Codigo_categoria = int.Parse(dataTable.Rows[i][4].ToString())

                };

                listaVeiculos.Add(veiculo);
            }

            return listaVeiculos;
        }
    }
}
