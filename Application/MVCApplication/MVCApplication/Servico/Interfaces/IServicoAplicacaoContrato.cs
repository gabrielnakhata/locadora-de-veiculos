using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using System.Collections.Generic;

namespace MVCApplication.Servico.Interfaces
{
    public interface IServicoAplicacaoContrato
    {
        IEnumerable<SelectListItem> ListaContratosDropDownList();
        IEnumerable<ContratoViewModel> Listagem();
        ContratoViewModel CarregarRegistro(int IdCliente);
        void Cadastrar(ContratoViewModel contrato);
        void Excluir(int id);
    }
}
