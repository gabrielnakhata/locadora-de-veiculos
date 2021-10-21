using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LocadoraVeiculo.Repository
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
    }
}
