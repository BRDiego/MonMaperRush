using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class SourceDAO
    {
        readonly ConexaoSQLServer _conexao = new ConexaoSQLServer();

        public string Save(Source source)
        {
            try
            {
                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("SOURCE_SAVE", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@ID", SqlDbType.SmallInt)
                        .Value = source.Id;
                    procedure.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar)
                        .Value = source.Description;

                    procedure.Parameters.Add("@PROC_RESULT", SqlDbType.VarChar,300)
                        .Direction = ParameterDirection.Output;

                    procedure.ExecuteNonQuery();

                    return procedure.Parameters["@PROC_RESULT"].Value.ToString();

                }
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}");
            }
        }


        public Source Read(short id)
        {
            try
            {
                Source source = new Source();

                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("SOURCE_READ", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@ID", SqlDbType.VarChar)
                        .Value = id;
                    procedure.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar)
                        .Value = String.Empty;

                    SqlDataReader reader = procedure.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        source = new Source()
                        {
                            Id = short.Parse(reader["ID"].ToString()),
                            Description = reader["DESCRIPTION"].ToString()
                        };
                    }
                    reader.Close();
                }

                return source;
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}", err.InnerException);
            }
        }
        public Source Read(string description)
        {
            try
            {
                Source source = new Source()
                {
                    Description = description
                };

                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("SOURCE_READ", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@ID", SqlDbType.VarChar)
                        .Value = 0;
                    procedure.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar)
                        .Value = description;

                    SqlDataReader reader = procedure.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        source = new Source()
                        {
                            Id = short.Parse(reader["ID"].ToString()),
                            Description = reader["DESCRIPTION"].ToString()
                        };
                    }
                    reader.Close();

                    if (source.Id == 0)
                    {
                        Save(source);
                        source = Read(description);
                    }
                }

                return source;
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}", err.InnerException);
            }
        }


    }
}
