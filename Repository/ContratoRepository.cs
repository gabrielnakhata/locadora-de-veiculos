using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class ContratoRepository : Repository, IContratoRepository
    {
        public void RegistrarContrato (Contrato contrato)
        {
            string sql = $"insert into contrato(numero, placa, id_cliente, data, data_previsao_devolucao, data_devolucao, valor) values(" +
                         $"'{contrato.Numero}', " +
                         $"'{contrato.Placa}', " +
                         $"'{contrato.IdCliente}', " +
                         $"'{contrato.Data}', " +
                         $"'{contrato.DataPrevisaoDevolucao}', " +
                         $"'{contrato.DataDevolucao}', " +
                         $"'{contrato.Valor}')";

            ExecuteCommand(sql);
        }

        public void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevisaoDevolucao, decimal valor)
        {
           
            string sql = $"Update contrato set" +
                         $" data_prevista_devolucao = '{dataPrevisaoDevolucao:yyyyMMdd HH:mm}', " +
                         $" valor = {valor} " +                 
                         $" where numero = '{numeroContrato}'";

            ExecuteCommand(sql);
        }
        public void Delete(string id)
        {
            string sql = $"delete from contrato" +
                         $" where numero = '{id}'";

            ExecuteCommand(sql);
        }

        public IEnumerable<Contrato> List(string id)
        {
            string sql = $"select numero, placa, id_cliente, data, data_previsao_devolucao, data_devolucao from contrato ";
            if (id != null) { sql += $" where id_cliente = {id}"; }

            var dataTable = Read(sql);

            List<Contrato> listaContratos = new List<Contrato>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Contrato contrato = new Contrato()
                {
                    Numero = dataTable.Rows[i][0].ToString(),
                    Placa = dataTable.Rows[i][1].ToString(),
                    IdCliente = int.Parse(dataTable.Rows[i][2].ToString()),
                    Data = DateTime.Parse(dataTable.Rows[i][3].ToString()),
                    DataPrevisaoDevolucao = DateTime.Parse(dataTable.Rows[i][4].ToString()),
                    DataDevolucao = DateTime.Parse(dataTable.Rows[i][5].ToString()),
                    Valor = decimal.Parse(dataTable.Rows[i][6].ToString()),


                };

                listaContratos.Add(contrato);
            }
            return listaContratos;
        }

    }
}
