using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using System.Collections.Generic;

namespace MVCApplication.Servico.Interfaces
{
    public interface IServicoAplicacaoCategoria
    {
        IEnumerable<SelectListItem> ListaCategoriaDropDownList();
        IEnumerable<CategoriaViewModel> Listagem();
        CategoriaViewModel CarregarRegistro(int codigoCategoria);
        void Cadastrar(CategoriaViewModel categoria);
        void Excluir(int id);
    }
}
