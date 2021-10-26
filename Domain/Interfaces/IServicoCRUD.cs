using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IServicoCRUD<TEntidade>
         where TEntidade : class
    {
        IEnumerable<TEntidade> Listagem();
        void Cadastrar(TEntidade categoria);
        TEntidade CarregarRegistro(int id);
        void Excluir(int id);
    }
}
