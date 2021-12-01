
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApplication.Models;
using System.Collections.Generic;

namespace MVCApplication.Servico.Interfaces
{
    public interface IServicoAplicacaoVeiculo
    {
        IEnumerable<SelectListItem> ListaVeiculosDropDownList();
        IEnumerable<VeiculoViewModel> Listagem();
        VeiculoViewModel CarregarRegistro(string codigoVeiculo);
        void Cadastrar(VeiculoViewModel veiculo);
        void Excluir(string id);
    }
}
