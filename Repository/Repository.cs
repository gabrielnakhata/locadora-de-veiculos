using Domain.Repositories;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Repository
{
    public abstract class Repository
    { 
    //    <TEntidade> : DbConnection, IRepository<TEntidade>
    //    where TEntidade : codigo, new()

    //{
    //    protected DbConnection Db;
    //    protected DbConnection<TEntidade> Dbset;
    //    public Repository(DbConnection dbConnection)
    //    {
    //        Db = dbConnection;
    //        DbConnection = Db.Set<TEntidade>();
    //    }

    //    public void Create(TEntidade Entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public TEntidade Read(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<TEntidade> Read()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
