using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        public void Create(Categoria categoria);
        public void Delete(int id);
        public void Update(Categoria categoria);
    }
}
