using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class DrugBLL
    {
        IDAL.IDrugDAL iDrug = DALFactory.DataAccess.CreateDrugDAL();
        private static DrugBLL instance;

        private DrugBLL()
        {
        }

        public static DrugBLL GetDrugBLLL()
        {
            if (instance == null)
            {
                instance = new DrugBLL();
            }
            return instance;
        }
        
        public DataTable GetAllDrug()
        {
            return iDrug.GetDrugDataList();
        }

        public DataTable GetDrugsByAB(string ab)
        {
            return iDrug.FindDrugByAB(ab);
        }

        public DataTable GetDrugsByName(string name)
        {
            return iDrug.FindDrugByName(name);
        }

        public double GetDrugsCount()
        {
            return iDrug.GetDurgsCount();
        }
    }
}
