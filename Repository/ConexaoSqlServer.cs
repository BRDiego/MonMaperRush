using System;
using System.Data.SqlClient;

namespace Repository
{
    public class ConexaoSQLServer
    {
        public SqlConnection OpenConnection()
        {
            try
            {
                string connString = "Data Source=DESKTOP-K2TRM5Q\\SQLEXPRESS;Initial Catalog=MONMAPER;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(connString);
                conexao.Open();
                return conexao;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
