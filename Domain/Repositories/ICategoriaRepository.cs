using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface ICategoriaRepository
    {
        public void Create(Categoria categoria);
        public void Delete(int id);
        public void Update(Categoria categoria);
        public IEnumerable<Categoria> List(int? id);
    }
}
