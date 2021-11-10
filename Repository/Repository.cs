using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public abstract class Repository<TEntidade> : IRepository<TEntidade>
        where TEntidade : class, new()

    {
        private SqlConnection conn;
        private string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

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

        public TEntidade Read(int id)
        {
            return Read(id);
        }

        public IEnumerable<TEntidade> Read()
        {
            return Read();
        }

    }
}