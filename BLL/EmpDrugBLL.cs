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

        //通过调用dal层利用模糊匹配查询得出用户需要的验方
        public DataTable GetEmpDrugsByAb(string ab)
        {
            return iEmpDrug.GetDrugListByAb(ab);
        }

        public DataTable GetEmpDrugsByName(string Name)
        {
            DataTable datatab = iEmpDrug.GetDrugListByName(Name);
            return datatab;
        }
    }
}
