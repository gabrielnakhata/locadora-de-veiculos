using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IRepository<TEntidade>
    where TEntidade : class
    {
        void Create(TEntidade Entity);
        TEntidade Read(int id);
        void Delete(int id);
        IEnumerable<TEntidade> Read();
    }
}
