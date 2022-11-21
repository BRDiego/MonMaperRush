using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    internal class LogDAO
    {
        private  readonly ConexaoSQLServer _connection;
        internal LogDAO(ConexaoSQLServer connection)
        {
            _connection = connection;
        }

        public  void Write(EntitiesControl entity,string description, char action, DateTime moment)
        {
            try
            {
                Log log = new Log()
                {
                    Description = description,
                    Action = action,
                    Entity = entity,
                    Moment = moment
                };

                using (SqlConnection conn = _connection.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("LOG_INSERT", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@ENTITY", SqlDbType.SmallInt)
                        .Value = (short)log.Entity;
                    procedure.Parameters.Add("@MOMENT", SqlDbType.DateTime)
                        .Value = log.Moment;
                    procedure.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar)
                        .Value = log.Description;
                    procedure.Parameters.Add("@ACTION", SqlDbType.Char)
                        .Value = log.Action ;

                    if (procedure.ExecuteNonQuery() != 1)
                        throw new Exception($"Log insertion had unexpected return!");
                }
            }
            catch (Exception err)
            {
                throw new Exception($"Log Failure: {err.Message}");
            }
        }
    }
}
