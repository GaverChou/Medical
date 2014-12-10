using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQlDAL
{
    public class SqlDbHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //设置数据库连接字符串
        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }

        public static DataTable ExecuteDataTable(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            DataTable data = new DataTable();//实例化DataTable，用于装载查询结果集
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    //设置command的CommandType为指定的CommandType
                    command.CommandType = commandType;
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    //通过包含查询SQL的SqlCommand实例来实例化SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);  //填充DataTable
                }
            }
            return data;
        }

        //两个重载的ExecuteDataTable()，以方便不同参数时的调用
        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText, CommandType.Text, null);
        }

        public static DataTable ExecuteDataTable(string commandText, CommandType commandType)
        {
            return ExecuteDataTable(commandText, commandType, null);
        }

        public static SqlDataReader ExecuteReader(string commandText,
                CommandType commandType, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connString);
            //SqlTransaction tran = connection.BeginTransaction();
            SqlCommand command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //两个重载的ExecuteReader()，以方便不同参数时的调用
        public static SqlDataReader ExecuteReader(string commandText)
        {
            return ExecuteReader(commandText, CommandType.Text, null);
        }

        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType)
        {
            return ExecuteReader(commandText, commandType, null);
        }

        public static Object ExecuteScalar(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            Object result = null;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    //设置command的CommandType为指定的CommandType
                    command.CommandType = commandType;
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }
            return result; //返回查询结果的第1行第1列，忽略其他行和列
        }

        //两个重载的ExecuteScalar(),以方便不同参数时的调用
        public static Object ExecuteScalar(string commandText)
        {
            return ExecuteScalar(commandText, CommandType.Text, null);
        }

        public static Object ExecuteScalar(string commandText, CommandType commandType)
        {
            return ExecuteScalar(commandText, commandType, null);
        }

        public static int ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    //设置command的CommandType为指定的CommandType
                    command.CommandType = commandType;
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open();
                    count = command.ExecuteNonQuery();
                }
            }
            return count;
        }

        //两个重载的ExecuteNonQuery(),以方便不同参数时的调用
        public static int ExecuteNonQuery(string commandText)
        {
            return ExecuteNonQuery(commandText, CommandType.Text, null);
        }

        public static int ExecuteNonQuery(string commandText, CommandType commandType)
        {
            return ExecuteNonQuery(commandText, commandType, null);
        }
    }
}
