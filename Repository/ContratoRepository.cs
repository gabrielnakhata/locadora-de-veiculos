using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class ContratoRepository : Repository<Contrato>, IContratoRepository
    {
        public void RegistrarContrato (Contrato contrato)
        {
            string sql = $"insert into contrato(numero, placa, id_cliente, data, data_previsao_devolucao, valor) values(" +
                         $"'{contrato.Numero}', " +
                         $"'{contrato.Placa}', " +
                         $"'{contrato.IdCliente}', " +
                         $"'{contrato.DataContratacao}', " +
                         $"'{contrato.DataPrevistaDevolucao}', " +
                         $"'{contrato.Valor}')";

            ExecuteCommand(sql);
        }

        public void AlterarPrevisaoFechamento(string numeroContrato, DateTime dataPrevistaDevolucao, decimal valor)
        {
           
            string sql = $"Update contrato set" +
                         $" data_previsao_devolucao = '{dataPrevistaDevolucao:yyyyMMdd HH:mm}', " +
                         $" valor = {valor} " +                  // aspas simples somente para string e datas.
                         $" where numero = '{numeroContrato}'";

            ExecuteCommand(sql);
        }
        public void Delete(int id)
        {
            string sql = $"delete from contrato" +
                         $" where id = {id}";

            ExecuteCommand(sql);
        }

        public void AlterarPrevisaoFechamento(Contrato contrato)
        {
            throw new NotImplementedException();
        }
    }
}
