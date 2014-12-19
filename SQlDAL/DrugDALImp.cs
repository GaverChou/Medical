using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IDAL;

namespace SQlDAL
{
    public partial class DrugDALImp:IDrugDAL
    {
        public DataTable GetDrugDataList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [drug]");
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }

        public bool DeleteByID(int did)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [drug] ");
            strSql.Append("where drug_id=@drug_id ");
            SqlParameter[] parameters = { new SqlParameter("@drug_id", SqlDbType.Int) };
            parameters[0].Value = did;
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

        public bool Add(Model.Drug drug)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [drug]");
            strSql.Append("(drug_ab,drug_name,unit_price,unit ,in_price ,stock ,from_where ,wei_jin ,notice ,effect,use_up,use_down) values");
            strSql.Append("(@drug_ab,@drug_name,@unit_price,@unit ,@in_price ,@stock ,@from_where ,@wei_jin ,@notice ,@effect,@use_up,@use_down)");
            SqlParameter[] parameters = {
                                            new SqlParameter("@drug_ab",SqlDbType.VarChar,10),
                                            new SqlParameter("@drug_name",SqlDbType.VarChar,16),
                                            new SqlParameter("@unit_price",SqlDbType.Decimal,10),
                                            new SqlParameter("@unit",SqlDbType.VarChar,5),
                                            new SqlParameter("@in_price",SqlDbType.Decimal,10),
                                            new SqlParameter("@stock",SqlDbType.Decimal,10),
                                            new SqlParameter("@from_where",SqlDbType.VarChar,16),
                                            new SqlParameter("@wei_jin",SqlDbType.VarChar,32),
                                            new SqlParameter("@notice",SqlDbType.VarChar,64),
                                            new SqlParameter("@effect",SqlDbType.VarChar,64),
                                            new SqlParameter("@use_up",SqlDbType.Decimal,10),
                                            new SqlParameter("@use_down",SqlDbType.Decimal,10)
                                        };
            parameters[0].Value = drug.Drug_ab ;
            parameters[1].Value = drug.Drug_name;
            parameters[2].Value = drug.Unit_price;
            parameters[3].Value = drug.Unit;
            parameters[4].Value = drug.In_price;
            parameters[5].Value = drug.Stock;
            parameters[6].Value = drug.From_where;
            parameters[7].Value = drug.Wei_jin;
            parameters[8].Value = drug.Notice;
            parameters[9].Value = drug.Effect;
            parameters[10].Value = drug.Use_up;
            parameters[11].Value = drug.Use_down;
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

        public bool Update(Model.Drug drug)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [drug] set");
            strSql.Append("(drug_ab=@drug_ab,drug_name=@drug_name,unit_price=@unit_price,"+
            "unit=@unit,in_price=@in_price ,stock=@stock,from_where=@from_where"+
            ",wei_jin=@wei_jin ,notice=@notice ,effect=@effect,use_up=@use_up,use_down=@use_down");
            strSql.Append(" where drug_id =@drug_id  ");
            SqlParameter[] parameters ={ 
                                            new SqlParameter("@drug_ab",SqlDbType.VarChar,10),
                                            new SqlParameter("@drug_name",SqlDbType.VarChar,16),
                                            new SqlParameter("@unit_price",SqlDbType.Decimal,10),
                                            new SqlParameter("@unit",SqlDbType.VarChar,5),
                                            new SqlParameter("@in_price",SqlDbType.Decimal,10),
                                            new SqlParameter("@stock",SqlDbType.Decimal,10),
                                            new SqlParameter("@from_where",SqlDbType.VarChar,16),
                                            new SqlParameter("@wei_jin",SqlDbType.VarChar,32),
                                            new SqlParameter("@notice",SqlDbType.VarChar,64),
                                            new SqlParameter("@effect",SqlDbType.VarChar,64),
                                            new SqlParameter("@use_up",SqlDbType.Decimal,10),
                                            new SqlParameter("@use_down",SqlDbType.Decimal,10),
                                            new SqlParameter("@drug_id",SqlDbType.Int)
                                       };
            parameters[0].Value = drug.Drug_ab;
            parameters[1].Value = drug.Drug_name;
            parameters[2].Value = drug.Unit_price;
            parameters[3].Value = drug.Unit;
            parameters[4].Value = drug.In_price;
            parameters[5].Value = drug.Stock;
            parameters[6].Value = drug.From_where;
            parameters[7].Value = drug.Wei_jin;
            parameters[8].Value = drug.Notice;
            parameters[9].Value = drug.Effect;
            parameters[10].Value = drug.Use_up;
            parameters[11].Value = drug.Use_down;
            parameters[12].Value = drug.Id;
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


        public DataTable FindDrugByAB(string ab)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select drug_ab,drug_name,unit,unit_price from drug where drug_ab like '%"+ab+"%'");
            DataTable tab = SqlDbHelper.ExecuteDataTable(strSql.ToString(),CommandType.Text);
            return tab;
        }


        public Model.Drug GetDrugById(int did)
        {
            throw new NotImplementedException();
        }


        public DataTable FindDrugByName(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from drug where drug_name=@drug_name");
            SqlParameter[] parameters = { new SqlParameter("@drug_name", SqlDbType.VarChar, 16) };
            parameters[0].Value = name;
            DataTable tab = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text,parameters);
            return tab;
        }


        public double GetDurgsCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(stock) from drug");
            SqlDataReader reader = SqlDbHelper.ExecuteReader(strSql.ToString());
            if (reader.Read())
            {
                return Double.Parse(reader[0].ToString());
            }
            else
            {
                return 0;
            }
        }


        public int GetDrugTypeCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from [drug]");
            SqlDataReader reader = SqlDbHelper.ExecuteReader(strSql.ToString());
            if (reader.Read())
            {
                return int.Parse(reader[0].ToString());
            }
            else
            {
                return -1;
            }
        }
    }
}
