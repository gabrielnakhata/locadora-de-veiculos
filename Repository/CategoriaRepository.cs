using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;

namespace Repository
{
    public class CategoriaRepository : Repository, ICategoriaRepository
    {
        public void Create(Categoria categoria)
        {
            string sql = $"insert into categoria (descricao) values(" +
                           $"'{categoria.Descricao}')";

            ExecuteCommand(sql);
        }

        public void Delete(int id)
        {
            string sql = $"delete from categoria" +
                       $" where codigo = {id}";

            ExecuteCommand(sql);
        }

        public IEnumerable<Categoria> List(int? id)
        {
            string sql = $"select codigo, descricao from categoria ";
            if (id != null) { sql += $" where codigo = {id}";  }
           
            var dataTable = Read(sql);

            List<Categoria> listaCategoria = new List<Categoria>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Categoria categoria = new Categoria()
                {
                    Codigo = int.Parse(dataTable.Rows[i][0].ToString()),
                    Descricao = dataTable.Rows[i][1].ToString()
                };

                listaCategoria.Add(categoria);
            }

            return listaCategoria;
        }

        public void Update(Categoria categoria)
        {
            string sql = $"update categoria set" +
                          $" descricao = '{categoria.Descricao}'" +
                          $" where codigo = '{categoria.Codigo}'";

            ExecuteCommand(sql);
        }
    }
}
