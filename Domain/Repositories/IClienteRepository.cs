using Domain.Entities;

namespace Domain.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        public void Create(Cliente cliente);
        public void Delete(int id);
        public void Update(Cliente cliente);
    }
}