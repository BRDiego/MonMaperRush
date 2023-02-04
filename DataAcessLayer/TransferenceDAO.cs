using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Repository;


namespace DataAcessLayer
{
    public class TransferenceDAO
    {

        readonly ConexaoSQLServer _conexao = new ConexaoSQLServer();

        public int Save(Transference transference)
        {
            try
            {
                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("TRANSFERENCE_SAVE", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@ID", SqlDbType.SmallInt)
                        .Value = transference.Id;
                    procedure.Parameters.Add("@DATE", SqlDbType.Date)
                        .Value = transference.Date;
                    procedure.Parameters.Add("@AMOUNT", SqlDbType.Decimal)
                        .Value = transference.Amount;
                    procedure.Parameters.Add("@KIND", SqlDbType.SmallInt)
                        .Value = (short)transference.Kind;
                    procedure.Parameters.Add("@DETAILS", SqlDbType.VarChar)
                        .Value = transference.Details;

                    DateTime actionMoment = DateTime.Now;

                    procedure.Parameters.Add("@ACTION_MOMENT", SqlDbType.DateTime)
                        .Value = actionMoment;
                    procedure.Parameters.Add("@PROC_RESULT", SqlDbType.SmallInt)
                        .Direction = ParameterDirection.Output;

                    if (transference.Id == 0)
                        transference.CreationDate = actionMoment;
                    else
                        transference.UpdateDate = actionMoment;

                    var dao = new SourceDAO();

                    transference.Source = dao.Read(transference.Source.Description);

                    procedure.Parameters.Add("@SOURCE", SqlDbType.SmallInt)
                        .Value = transference.Source.Id;

                    procedure.ExecuteNonQuery();

                    if ((short)procedure.Parameters["@PROC_RESULT"].Value == 0)
                        throw new ProcedureException("Falha ao realizar o procedimento!");

                    new LogDAO(_conexao).Write(EntitiesControl.TRANSFERENCE,
                        "User saved Transference",
                         transference.Id == 0 ? 'I' : 'U',
                        actionMoment);

                    return transference.Id == 0 ? 1 : 2;
                }
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}");
            }
        }

        public bool Delete(short id)
        {
            try
            {
                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("TRANSFERENCE_DELETE", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    procedure.Parameters.Add("@ID", SqlDbType.SmallInt)
                        .Value = id;
                    procedure.Parameters.Add("@PROC_RESULT", SqlDbType.SmallInt)
                        .Direction = ParameterDirection.Output;

                    procedure.ExecuteNonQuery();

                    if ((short)procedure.Parameters["@PROC_RESULT"].Value == 0)
                        throw new ProcedureException("Falha ao realizar o procedimento!");

                    new LogDAO(_conexao).Write(EntitiesControl.TRANSFERENCE,
                        "User deleted Transference",
                         'D',
                        DateTime.Now);

                    return true;
                }
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}");
            }
        }

        public Transference Read(short id)
        {
            try
            {
                Transference transference = new Transference();

                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("TRANSFERENCE_READ", conn);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@ID", SqlDbType.VarChar)
                        .Value = id;

                    SqlDataReader reader = procedure.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        transference = new Transference();

                        transference.Id = short.Parse(reader["TRANSFERENCE"].ToString());
                        transference.Date = DateTime.Parse(reader["DATE"].ToString());
                        transference.Amount = decimal.Parse(reader["AMOUNT"].ToString());
                        transference.Source.Id = short.Parse(reader["SOURCE"].ToString());
                        transference.Source.Description = reader["SOURCE_DESCRIPTION"].ToString();
                        transference.Details = reader["DETAILS"].ToString();
                        transference.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
                        transference.UpdateDate = reader["UPDATE_DATE"] == DBNull.Value ?
                                 new DateTime() :
                                 DateTime.Parse(reader["UPDATE_DATE"].ToString());

                        transference.SetKind(short.Parse(reader["KIND"].ToString()));
                    }
                    reader.Close();
                }

                return transference;
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}", err.InnerException);
            }
        }

        public List<Transference> ListTransferences()
        {
            try
            {
                DataTable dTable = new DataTable();

                using (SqlConnection conn = _conexao.OpenConnection())
                {
                    SqlCommand procedure = new SqlCommand("TRANSFERENCE_SEARCH", conn);
                    procedure.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(procedure);

                    da.Fill(dTable);
                }

                List<Transference> list = new List<Transference>();

                if (dTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        Transference transference = new Transference()
                        {
                            Id = short.Parse(dTable.Rows[i]["TRANSFERENCE"].ToString()),
                            Date = DateTime.Parse(dTable.Rows[i]["DATE"].ToString()),
                            Amount = decimal.Parse(dTable.Rows[i]["AMOUNT"].ToString()),
                            //Source = dTable.Rows[i]["SOURCE"].ToString(),
                            Details = dTable.Rows[i]["DETAILS"].ToString(),
                            CreationDate = DateTime.Parse(dTable.Rows[i]["CREATION_DATE"].ToString())
                        };

                        if (dTable.Rows[i]["UPDATE_DATE"] != DBNull.Value)
                            transference.UpdateDate = DateTime.Parse(dTable.Rows[i]["UPDATE_DATE"].ToString());

                        transference.SetKind(short.Parse(dTable.Rows[i]["KIND"].ToString()));

                        if (dTable.Rows[i]["UPDATE_DATE"] != DBNull.Value)
                            DateTime.Parse(dTable.Rows[i]["UPDATE_DATE"].ToString());

                        list.Add(transference);
                    }
                }

                return list;
            }
            catch (Exception err)
            {
                throw new Exception($"Method Failure! [{System.Reflection.MethodBase.GetCurrentMethod()}]:{Environment.NewLine}{Environment.NewLine}{err.Message}");
            }
        }
    }
}
