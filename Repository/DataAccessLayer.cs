using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class DataAccessLayer
    {
        private SqlConnection conn;

        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public void Conectar()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }

                conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao tentar estabelecer conexão com o Banco de Dados: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar fechar a conexão do Banco de Dados: " + ex.Message);
            }
        }

        public DataTable RetornaDataTable(string sql)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(data);
            da = null;
            return data;
        }

        public SqlDataReader RetornaDataReader(string sql)
        {
            SqlDataReader data;
            SqlCommand comando = new SqlCommand(sql, conn);
            data = comando.ExecuteReader();
            return data;
        }

        public void ExecutarComandoSQL(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.ExecuteNonQuery();
            comando = null;
        }

        public int RetornaUltimoId(string tabela, string coluna)
        {
            DataTable data = this.RetornaDataTable("select max(" + coluna + ") as id from " + tabela);
            try
            {
                int retorno = int.Parse(data.Rows[0]["id"].ToString());
                data.Dispose();
                return retorno;
            }
            catch
            {
                return 1;
            }
        }
    }
}
