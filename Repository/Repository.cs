using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public abstract class Repository : IRepository
    {
        private SqlConnection conn;
        private readonly string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

        private void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        private void ExecuteQuery(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = conn;
            sqlCommand.ExecuteNonQuery();
        }

        public void ExecuteCommand(string sql)
        {
            OpenConnection();
            ExecuteQuery(sql);
        }

        public DataTable Read(string sql)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = conn;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

    }
}