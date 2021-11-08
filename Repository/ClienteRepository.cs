using Domain.Entities;
using Domain.Repositories;

namespace Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
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

        public void Delete(int id)
        {
            string sql = $"delete from cliente" +
                         $" where id = {id}";

            ExecuteCommand(sql);
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


