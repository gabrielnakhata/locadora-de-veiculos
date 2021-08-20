using LocadoraVeiculo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LocadoraVeiculo.Repository
{
    public class ContratoRepository
    {
        public void Insert(Contrato contrato)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"insert into contrato(numero, placa, id_cliente, data, data_previsao_devolucao, data_devolucao, valor) values(" +
                         $"'{contrato.Id}', " +
                         $"'{contrato.Placa}', " +
                         $"'{contrato.IdCliente}', " +
                         $"'{contrato.DataContratacao}', " +
                         $"'{contrato.DataPrevistaDevolucao}', " +
                         $"'{contrato.DataDevolucao}', " +
                         $"'{contrato.Valor}')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public void Update(Contrato contrato)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"Update contrato set" +
                         $"'{contrato.Id}', " +
                         $"'{contrato.Placa}', " +
                         $"'{contrato.IdCliente}', " +
                         $"'{contrato.DataContratacao}', " +
                         $"'{contrato.DataPrevistaDevolucao}', " +
                         $"'{contrato.DataDevolucao}', " +
                         $"'{contrato.Valor}' " +
                         $" where Id = '{contrato.Id}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }
    }
}
