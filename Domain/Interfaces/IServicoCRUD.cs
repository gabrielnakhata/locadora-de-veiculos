using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IServicoCRUD<TEntidade>
         where TEntidade : class
    {
        IEnumerable<TEntidade> Listagem();
        void Cadastrar(TEntidade entidade);
        void Atualizar(TEntidade entidade);
        TEntidade CarregarRegistro(string id);
        void Excluir(string id);
    }
}
