using System.Data;

namespace Domain.Repositories
{
    public interface IRepository
    {
        void ExecuteCommand(string sql);
        DataTable Read(string sql);
    }
}