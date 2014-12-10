using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class EmptabBLL
    {
        IDAL.IEmpiricalDAL iEmpiricalDAL = DALFactory.DataAccess.CreateEmpiricalDAL();
        private static EmptabBLL instance;

        private EmptabBLL()
        {
        }

        public static EmptabBLL GetEmptabBLL()
        {
            if (instance == null)
            {
                instance = new EmptabBLL();
            }
            return instance;
        }

        public DataTable GetAllEmpTab()
        {
            return iEmpiricalDAL.GetEmpDataList();
        }

        public bool UpdateEmpTab(Model.EmpTab emptab)
        {
            return iEmpiricalDAL.Update(emptab);
        }

        public DataTable GetAllEmpTabByAb(string ab)
        {
            return iEmpiricalDAL.GetEmpDataListByAb(ab);
        }
    }
}
