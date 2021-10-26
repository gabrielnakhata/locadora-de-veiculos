using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IRepository<TEntidade>
        where TEntidade: class
    {
        void Create(TEntidade Entity);
        TEntidade Read(int id);
        void Delete(int id);
        IEnumerable<TEntidade> Read();
    }
}
