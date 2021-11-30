using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        public void Create(Cliente cliente);
        public void Delete(string id);
        public void Update(Cliente cliente);
        public IEnumerable<Cliente> List(string id);
    }
}