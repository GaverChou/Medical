using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SQlDAL
{
    public partial class Patient_TabDALImp:IDAL.IPatientTabDAL
    {
        public bool DeleteById(int pid)
        {
            throw new NotImplementedException();
        }

        public bool AddPatientTab(Model.Patient_Tab pat_tab)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [patient_tab]");
            strSql.Append("(pid,xianbingshi,zhenduan,chufang_count) values");
            strSql.Append("(@pid,@xianbingshi,@zhenduan,@chufang_count)");
            SqlParameter[] parameters = {
                                            new SqlParameter("@pid",SqlDbType.Int),
                                            new SqlParameter("@xianbingshi",SqlDbType.VarChar,32),
                                            new SqlParameter("@zhenduan",SqlDbType.VarChar,32),
                                            new SqlParameter("@chufang_count",SqlDbType.Int)
                                        };
            parameters[0].Value = pat_tab.Pid;
            parameters[1].Value = pat_tab.Xianbingshi;
            parameters[2].Value = pat_tab.Zhengduan;
            parameters[3].Value = pat_tab.Chufang_count;
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (row == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
