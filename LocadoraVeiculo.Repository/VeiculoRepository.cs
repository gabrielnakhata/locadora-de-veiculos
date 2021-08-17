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
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"insert into veiculo(placa, ano, marca, modelo) " + "values" +
                         $"'{veiculo.Placa}', " +
                         $"'{veiculo.Ano}', " +
                         $"'{veiculo.Marca}', " +
                         $"'{veiculo.Modelo}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();

        }
    }
}
