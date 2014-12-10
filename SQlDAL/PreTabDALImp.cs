using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using IDAL;

namespace SQlDAL
{
    public partial class PreTabDALImp:IPreTabDAL
    {
        public System.Data.DataTable GetPreDrugsById(int pid)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select drug.drug_name,prescribeTab.drug_count,drug.unit from patient_data,prescribeTab,drug");
            strSQL.Append(" where patient_data.pid=@pid ");
            strSQL.Append("and patient_data.pid = prescribeTab.pid ");
            strSQL.Append("and prescribeTab.drug_id=drug.drug_id");
            SqlParameter[] parameters = {
                                            new SqlParameter("@pid",SqlDbType.Int)
                                        };
            parameters[0].Value = pid;
            return SqlDbHelper.ExecuteDataTable(strSQL.ToString(), CommandType.Text, parameters);
        }
    }
}
