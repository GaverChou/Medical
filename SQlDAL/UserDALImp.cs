using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using Model;

namespace SQlDAL
{
    public partial class UserDALImp : IUserDAL
    {
        public UserDALImp()
        { }

        #region Method

        //判断用户名，密码是否正确
        public bool Login(string userName, string userPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [users]");
            strSql.Append(" where username=@UserName and passwd=@UserPassword");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@UserName",SqlDbType.VarChar,16), 
                                           new SqlParameter ("@UserPassword",SqlDbType.VarChar ,64)
                                       };
            parameters[0].Value = userName;
            parameters[1].Value = userPassword;

            int n = Convert.ToInt32(SqlDbHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters));
            if (n >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteByID(int uid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [users] ");
            strSql.Append("where uid=@uid ");
            SqlParameter[] parameters = { new SqlParameter("@uid", SqlDbType.Int) };
            parameters[0].Value = uid;
            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [users] set");
            strSql.Append(" passwd=@Password");
            strSql.Append(" where username=@UserName ");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@Password",SqlDbType .VarChar,16), 
                                           new SqlParameter ("@UserName",SqlDbType .VarChar ,64)
                                       };
            parameters[0].Value = model.Password;
            parameters[1].Value = model.UserName;
            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUser(Model.User user)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [users]");
            strSql.Append("(username,passwd) values");
            strSql.Append("(@UserName,@PassWord)");
            SqlParameter[] parameters = {
                                            new SqlParameter("@UserName",SqlDbType.VarChar,16),
                                            new SqlParameter("@PassWord",SqlDbType.VarChar,64)
                                        };
            parameters[0].Value = user.UserName;
            parameters[1].Value = user.Password;
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
            if (row == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddUserAndRetId(User user)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [users]");
            strSql.Append("(username,passwd) output inserted.uid values");
            strSql.Append("(@UserName,@PassWord)");
            SqlParameter[] parameters = {
                                            new SqlParameter("@UserName",SqlDbType.VarChar,16),
                                            new SqlParameter("@PassWord",SqlDbType.VarChar,64)
                                        };
            parameters[0].Value = user.UserName;
            parameters[1].Value = user.Password;
            SqlDataReader reader = SqlDbHelper.ExecuteReader(strSql.ToString(), CommandType.Text, parameters);
            try
            {
                if (reader.Read())
                {
                    return Int16.Parse(reader[0].ToString());
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                reader.Close();
            }
            return -1;
        }

        public int FindIdByName(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select uid from [users]");
            strSql.Append(" where username=@UserName");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@UserName",SqlDbType.VarChar,16)
                                       };
            parameters[0].Value = name;
            SqlDataReader reader = SqlDbHelper.ExecuteReader(strSql.ToString(), CommandType.Text, parameters);
            if (reader.Read())
            {
                return Int16.Parse(reader[0].ToString());
            }
            else
            {
                return -1;
            }
        }
        #endregion Method




    }
}
