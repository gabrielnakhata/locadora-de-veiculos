using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public void Insert(Veiculo veiculo)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"insert into veiculo(placa, ano, marca, modelo) values(" +
                         $"'{veiculo.Placa}', " +
                         $"'{veiculo.Ano}', " +
                         $"'{veiculo.Marca}', " +
                         $"'{veiculo.Modelo}')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();

        }
        public void Update(Veiculo veiculo)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"update veiculo set" +
                         $" ano = '{veiculo.Ano}'," +
                         $" marca = '{veiculo.Marca}'," +
                         $" modelo = '{veiculo.Modelo}'" +
                         $" where placa = '{veiculo.Placa}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();

        }
        public void Delete(string placa)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"delete from veiculo" +
                         $" where placa = '{placa}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public void Create(Veiculo Entity)
        {
            throw new System.NotImplementedException();
        }

        public Veiculo Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Veiculo> Read()
        {
            throw new System.NotImplementedException();
        }
    }
}
