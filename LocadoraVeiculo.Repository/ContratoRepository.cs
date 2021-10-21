﻿using LocadoraVeiculo.Domain.Entities;
using LocadoraVeiculo.Domain.Repositories;
using System;
using System.Data.SqlClient;

namespace LocadoraVeiculo.Repository
{
    public class ContratoRepository : IContratoRepository
    {
        public void RegistrarContrato (Contrato contrato)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"insert into contrato(numero, placa, id_cliente, data, data_previsao_devolucao, valor) values(" +
                         $"'{contrato.Numero}', " +
                         $"'{contrato.Placa}', " +
                         $"'{contrato.IdCliente}', " +
                         $"'{contrato.DataContratacao}', " +
                         $"'{contrato.DataPrevistaDevolucao}', " +
                         $"'{contrato.Valor}')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"Update contrato set" +
                         $" data_previsao_devolucao = '{dataPrevistaDevolucao.ToString("yyyyMMdd HH:mm")}', " +
                         $" valor = {valor} " +                  // aspas simples somente para string e datas.
                         $" where numero = '{numeroContrato}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }
    }
}
