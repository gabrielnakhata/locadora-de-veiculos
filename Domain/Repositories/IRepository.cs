using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IRepository<TEntidade>
    where TEntidade : class
    {
        void ExecuteCommand(string sql);
        TEntidade Read(int id);
        IEnumerable<TEntidade> Read();
    }
}
