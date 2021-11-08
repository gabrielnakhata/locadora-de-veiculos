using Domain.Repositories;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> Read()
        {
            throw new NotImplementedException();
        }

    }
}