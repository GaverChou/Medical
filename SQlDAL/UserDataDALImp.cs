using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;

namespace SQlDAL
{
    public partial class UserDataDALImp:IUserDataDAL
    {
        public string findIdCardByName(string uid)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select idcard from [userData]");
            strSQL.Append("where username=@Name");
            SqlParameter[] parameters = {
                                            new SqlParameter("@Name",SqlDbType.VarChar,12)
                                        };
            parameters[0].Value = uid;
            string idcard = "";
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSQL.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["idcard"] != null && dt.Rows[0]["idcard"].ToString() != "")
                {
                    idcard = dt.Rows[0]["idcard"].ToString();
                }
            }
            return idcard ;
        }
        //(SELECT max(uid) FROM users)
        public bool addUserData(Model.UserData userData)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [userData]");
            strSql.Append("(uid,username,gender,idcard,address,department) values");
            strSql.Append("(@uid,@username,@gender,@idcard,@address,@department)");
            SqlParameter[] parameters = {
                                            new SqlParameter("@username",SqlDbType.VarChar,12),
                                            new SqlParameter("@gender",SqlDbType.VarChar,4),
                                            new SqlParameter("@idcard",SqlDbType.VarChar,18),
                                            new SqlParameter("@address",SqlDbType.VarChar,32),
                                            new SqlParameter("@department",SqlDbType.VarChar,32),
                                            new SqlParameter("@uid",SqlDbType.Int)
                                        };
            parameters[0].Value = userData.Username;
            parameters[1].Value = userData.Department;
            parameters[2].Value = userData.Idcard;
            parameters[3].Value = userData.Address;
            parameters[4].Value = userData.Department;
            parameters[5].Value = userData.Uid;
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

        public bool updateUserData(Model.UserData userData)
        {
            return false;
        }
    }
}
