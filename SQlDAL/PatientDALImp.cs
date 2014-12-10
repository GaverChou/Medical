using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace SQlDAL
{
    public partial class PatientDALImp:IPatientDAL
    {
        public SqlParameter[] ParsePara(Model.Patient patient)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@p_name",SqlDbType.VarChar,6),
                                            new SqlParameter("@gender",SqlDbType.VarChar,4),
                                            new SqlParameter("@old",SqlDbType.Int),
                                            new SqlParameter("@tel",SqlDbType.VarChar,15),
                                            new SqlParameter("@idcard",SqlDbType.VarChar,18),
                                            new SqlParameter("@d_id",SqlDbType.Int),
                                            new SqlParameter("@thumb",SqlDbType.Image)
                                        };
            parameters[0].Value = patient.P_name;
            parameters[1].Value = patient.Gender;
            parameters[2].Value = patient.Old;
            parameters[3].Value = patient.Tel;
            parameters[4].Value = patient.Idcard;
            parameters[5].Value = patient.D_ID;
            parameters[6].Value = patient.Thumb;
            return parameters;
        }

        public bool AddPatient(Model.Patient patient)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [patient_data](p_name,d_id,gender,old,"+
                "tel,idcard,thumb) values");
            strSql.Append("(@p_name,@d_id,@gender,@old,@tel,@idcard,@thumb)");
            

            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(),CommandType.Text,ParsePara(patient));
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePatient(Model.Patient patient)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [patient_data] set");
            strSql.Append("p_name=@p_name,gender=@gender,old=@old," +
                "tel=@tel,idcard=@idcard,d_id=@d_id,thumb=@thumb where pid=@pid");
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, ParsePara(patient));
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePatientById(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from patient where pid=@pid");
            SqlParameter[] parameters = {
                                            new SqlParameter("@pid",SqlDbType.Int)
                                        };
            parameters[0].Value = id;
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
            if(row>0)
            {
                return true;
            }else
            {
                return false;
            }
        }


        public Model.Patient GetPatientById(int pid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 p_name, old, gender from [patient_data] ");
            strSql.Append("where pid  = @pid  ");
            SqlParameter[] parameters = { new SqlParameter("@pid ", SqlDbType.Int) };
            parameters[0].Value = pid;
            Model.Patient model = new Model.Patient();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["p_name"] != null && dt.Rows[0]["p_name"].ToString() != "")
                {
                    model.P_name = dt.Rows[0]["p_name"].ToString();
                }
                if (dt.Rows[0]["gender"] != null && dt.Rows[0]["gender"].ToString() != "")
                {
                    model.Gender = dt.Rows[0]["gender"].ToString();
                }
                if (dt.Rows[0]["old"] != null && dt.Rows[0]["old"].ToString() != "")
                {
                    model.Old = Convert.ToInt16(dt.Rows[0]["old"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }


        public DataTable GetPatientList(int did)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("from patient_data,patient_tab where d_id=@d_id and patient_data.pid=patient_tab.pid");
            SqlParameter[] parameters = { new SqlParameter("@d_id", SqlDbType.Int) };
            parameters[0].Value = did;
            return SqlDbHelper.ExecuteDataTable(strSql.ToString(),CommandType.Text,parameters);
        }

        public DataTable GetPatientList(int did,string like)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("from patient_data,patient_tab where d_id=@d_id and patient_data.pid=patient_tab.pid and patient_data.p_name like '%"+like+"%'");
            SqlParameter[] parameters = { new SqlParameter("@d_id", SqlDbType.Int) };
            parameters[0].Value = did;
            return SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
        }

        public DataTable GetPatientList(int did, DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("from patient_data,patient_tab where d_id=@d_id and patient_data.pid=patient_tab.pid and patient_tab.look_date=@time");
            SqlParameter[] parameters = { new SqlParameter("@d_id", SqlDbType.Int),
                                        new SqlParameter("@time", SqlDbType.DateTime) };
            parameters[0].Value = did;
            parameters[1].Value = time;
            return SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
        }

        public DataSet GetPatientListForSet()
        {
            throw new NotImplementedException();
        }


        public bool UpdatePatientPhoto(int id,byte[] bytes)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("update [patient_data] set thumb=@bytes where pid=@pid");
             SqlParameter[] parameters = { new SqlParameter("@bytes", SqlDbType.Image), new SqlParameter("@pid", SqlDbType.Int) };
             parameters[0].Value = bytes;
             parameters[1].Value = id;
             int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
             if (row > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }
        }


        public int AddPatientRetId(Model.Patient patient)
        {
             StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [patient_data](p_name,d_id,gender,old,"+
                "tel,idcard,thumb) output inserted.pid values");
            strSql.Append("(@p_name,@d_id,@gender,@old,@tel,@idcard,@thumb)");


            SqlDataReader reader = SqlDbHelper.ExecuteReader(strSql.ToString(), CommandType.Text, ParsePara(patient));
            if (reader.Read())
            {
                return Int16.Parse(reader[0].ToString());
            }
            else
            {
                return -1;
            }
        }
    }
}
