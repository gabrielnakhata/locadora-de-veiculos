using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;

namespace Repository
{
    public class ClienteRepository : Repository, IClienteRepository
    {
        public void Create(Cliente cliente)
        {

            string sql = $"insert into cliente(nome, cpf, email, celular, cnh) values(" +
                            $"'{cliente.Nome}', " +
                            $"'{cliente.Cpf}', " +
                            $"'{cliente.Email}', " +
                            $"'{cliente.Celular}', " +
                            $"'{cliente.Cnh}')";

            ExecuteCommand(sql);
        }

        public void Delete(string id)
        {
            string sql = $"delete from cliente" +
                         $" where id = {id}";

            ExecuteCommand(sql);
        }

        public IEnumerable<Cliente> List(string id)
        {
            string sql = $"select id, nome, cpf, email, celular, cnh from cliente ";
            if (id != null) { sql += $" where id = {id}"; }

            var dataTable = Read(sql);

            List<Cliente> listaClientes = new List<Cliente>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Cliente cliente = new Cliente()
                {
                    Id = int.Parse(dataTable.Rows[i][0].ToString()),
                    Nome = dataTable.Rows[i][1].ToString(),
                    Cpf = dataTable.Rows[i][2].ToString(),
                    Email = dataTable.Rows[i][3].ToString(),
                    Celular = dataTable.Rows[i][4].ToString(),
                    Cnh = dataTable.Rows[i][5].ToString()

                };

                listaClientes.Add(cliente);
            }

            return listaClientes;
        }

        public void Update(Cliente cliente)
        {
            string sql = $"update cliente set" +
                         $" nome = '{cliente.Nome}'," +
                         $" cpf = '{cliente.Cpf}'," +
                         $" email = '{cliente.Email}'," +
                         $" celular = '{cliente.Celular}'," +
                         $" cnh = '{cliente.Cnh}'" +
                         $" where Id = '{cliente.Id}'";

            ExecuteCommand(sql);
        }
    }
}


