using Domain.Entities;
using Domain.Repositories;

namespace Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public void Create(Categoria categoria)
        {
            string sql = $"insert into cliente(descricao) values(" +
                           $"'{categoria.Descricao}')";

            ExecuteCommand(sql);
        }

        public void Delete(int id)
        {
            string sql = $"delete from categoria" +
                       $" where codigo = {id}";

            ExecuteCommand(sql);
        }

        public void Update(Categoria categoria)
        {
            string sql = $"update categoria set" +
                          $" descricao = '{categoria.Descricao}'," +
                          $" where codigo = '{categoria.Codigo}'";

            ExecuteCommand(sql);
        }
    }
}
