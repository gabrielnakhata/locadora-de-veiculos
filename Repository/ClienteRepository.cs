using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public void Insert(Cliente cliente)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"insert into cliente(nome, cpf, email, celular, cnh) values(" +
                         $"'{cliente.Nome}', " +
                         $"'{cliente.Cpf}', " +
                         $"'{cliente.Email}', " +
                         $"'{cliente.Celular}', " +
                         $"'{cliente.Cnh}')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public void Update(Cliente cliente)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"update cliente set" +
                         $" nome = '{cliente.Nome}'," +
                         $" cpf = '{cliente.Cpf}'," +
                         $" email = '{cliente.Email}'," +
                         $" celular = '{cliente.Celular}'," +
                         $" cnh = '{cliente.Cnh}'" +
                         $" where Numero = '{cliente.Id}'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }
        public void Delete(int id)
        {
            string connectionString = @"Server=DESKTOP-UG390NJ;Database=db-locadora-veiculo;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            string sql = $"delete from cliente" +
                         $" where Numero = {id}";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public void Create(Cliente Entity)
        {
            throw new System.NotImplementedException();
        }

        public Cliente Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> Read()
        {
            throw new System.NotImplementedException();
        }
    }
}


