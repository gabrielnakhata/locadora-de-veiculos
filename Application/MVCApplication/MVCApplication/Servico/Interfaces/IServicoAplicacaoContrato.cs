using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using System.Collections.Generic;

namespace MVCApplication.Servico.Interfaces
{
    public interface IServicoAplicacaoContrato
    {
        IEnumerable<SelectListItem> ListaContratosDropDownList();
        IEnumerable<SelectListItem> ListaClientesDropDownList();
        IEnumerable<ContratoViewModel> Listagem();
        ContratoViewModel CarregarRegistro(string IdCliente);
        void Cadastrar(ContratoViewModel contrato);
        void Excluir(string id);
    }
}
