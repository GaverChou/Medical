using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class EmpDrugBLL
    {
        IDAL.IEmpiricalDrugDAL iEmpDrug = DALFactory.DataAccess.CreateEmpiricalDrugDAL();
        private static EmpDrugBLL instance;

        private EmpDrugBLL()
        {
        }

        public static EmpDrugBLL GetDrugBLLL()
        {
            if (instance == null)
            {
                instance = new EmpDrugBLL();
            }
            return instance;
        }

        public DataTable GetEmpDrugs()
        {
            return iEmpDrug.GetDrugListByID();
        }

        public DataTable GetEmpDrugsByAb(string ab)
        {
            return iEmpDrug.GetDrugListByAb(ab);
        }

        public DataTable GetEmpDrugsByName(string Name)
        {
            return iEmpDrug.GetDrugListByName(Name);
        }
    }
}
