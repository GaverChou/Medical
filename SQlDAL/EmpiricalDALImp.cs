using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace SQlDAL
{
    public partial class EmpiricalDALImp:IEmpiricalDAL
    {

        public bool DeleteByID(int did)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [empirical] where em_id=@em_id");
            SqlParameter[] parameters = {
                                            new SqlParameter("@em_id ",SqlDbType.Int)
                                        };
            parameters[0].Value = did;
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

        public SqlParameter[] ParsePara(Model.EmpTab emptab)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@em_name",SqlDbType.VarChar,16),
                                            new SqlParameter("@em_ab",SqlDbType.VarChar,6),
                                            new SqlParameter("@from_where",SqlDbType.VarChar,256),
                                            new SqlParameter("@effect",SqlDbType.VarChar,256),
                                            new SqlParameter("@cure",SqlDbType.VarChar,256),
                                            new SqlParameter("@minus_and_add",SqlDbType.VarChar,64),
                                            new SqlParameter("@fangjie",SqlDbType.VarChar,128),
                                            new SqlParameter("@apply",SqlDbType.VarChar,512),
                                        };
            parameters[0].Value = emptab.Em_name;
            parameters[1].Value = emptab.Em_ab;
            parameters[2].Value = emptab.From_where;
            parameters[3].Value = emptab.Effect;
            parameters[4].Value = emptab.Cure;
            parameters[5].Value = emptab.Minus_and_add;
            parameters[6].Value = emptab.Fangjie;
            parameters[7].Value = emptab.Apply;
            return parameters;
        }


        public bool Add(Model.EmpTab empTab)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [empirical](em_name,em_ab,from_where,effect," +
                "cure,minus_and_add,fangjie,apply) values");
            strSql.Append("(@em_name,@em_ab,@from_where,@effect,@cure,@minus_and_add,@fangjie,@apply)");
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, ParsePara(empTab));
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Model.EmpTab empTab)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [empirical] set ");
            strSql.Append("em_name=@em_name,em_ab=@em_ab,from_where=@from_where," +
                "effect=@effect,cure=@cure,minus_and_add=@minus_and_add,fangjie=@fangjie,apply=@apply where em_name=@em_name");
            int row = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, ParsePara(empTab));
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable GetEmpDataList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("from empirical");
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }

        public DataTable GetEmpDataListByAb(string ab)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("from empirical where em_ab like '%" +  ab +"%'");
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }
    }
}
