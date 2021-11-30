using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Servico.Interfaces
{
    public interface IServicoAplicacaoCliente
    {
        IEnumerable<SelectListItem> ListaClientesDropDownList();
        IEnumerable<ClienteViewModel> Listagem();
        ClienteViewModel CarregarRegistro(string codigoCliente);
        void Cadastrar(ClienteViewModel cliente);
        void Excluir(string id);
    }
}
