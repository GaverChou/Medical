using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class PreBLL
    {
        private static PreBLL instance;
        IDAL.IPreTabDAL iPre = DALFactory.DataAccess.CreatePre();

        private PreBLL()
        {
        }

        public static PreBLL GetPreBLL()
        {
            if (instance == null)
            {
                instance = new PreBLL();
            }
            return instance;
        }

        public string GetPreDrugsById(int id)
        {
            DataTable data = iPre.GetPreDrugsById(id);
            StringBuilder drugs = new StringBuilder();
            for (int i = 0; i < data.Rows.Count;i++ )
            {
                if (data.Rows[i]["drug_name"] != null && data.Rows[i]["drug_name"].ToString() != "")
                {
                    drugs.Append(data.Rows[i]["drug_name"].ToString() + "\t");
                }
                if (data.Rows[i]["drug_count"] != null && data.Rows[i]["drug_count"].ToString() != "")
                {
                    drugs.Append(data.Rows[i]["drug_count"].ToString() + "");
                }
                if (data.Rows[i]["unit"] != null && data.Rows[i]["unit"].ToString() != "")
                {
                    drugs.Append(data.Rows[i]["unit"].ToString() + "\n");
                }
            }
            return drugs.ToString();
        }
    }
}
