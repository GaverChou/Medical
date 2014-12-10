using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace SQlDAL
{
    public partial class EmpiricalDrugDALImp:IEmpiricalDrugDAL
    {
        public System.Data.DataTable GetDrugListByID()
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select empirical.em_id,drug.drug_name,empiricalDrug.drug_count,drug.unit from empirical,empiricalDrug,drug");
            strSQL.Append(" where");
            strSQL.Append(" empirical.em_id = empiricalDrug.em_id ");
            strSQL.Append("and empiricalDrug.drug_id=drug.drug_id");
            return SqlDbHelper.ExecuteDataTable(strSQL.ToString());
        }

        public System.Data.DataTable GetDrugListByAb(string ab)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select empirical.em_id,drug.drug_name,empiricalDrug.drug_count,drug.unit from empirical,empiricalDrug,drug");
            strSQL.Append(" where");
            strSQL.Append(" empirical.em_id = empiricalDrug.em_id ");
            strSQL.Append("and empiricalDrug.drug_id=drug.drug_id and empirical.em_ab like '%" + ab + "%'");
            return SqlDbHelper.ExecuteDataTable(strSQL.ToString());
        }

        public bool DeleteByID(int did)
        {
            throw new NotImplementedException();
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
