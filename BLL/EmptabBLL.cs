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

        public bool AddEmpTab(Model.EmpTab emptab,out string msg)
        {
            msg = "";
            try
            {
                return iEmpiricalDAL.Add(emptab);
            }
            catch(Exception exp)
            {
                msg = exp.Message;
                return false;
            }
        }

        public bool DeleteEmp(string id, out string msg)
        {
            msg = "";
            try
            {
                msg = "删除成功！";
                return iEmpiricalDAL.DeleteByID(id);
            }
            catch (Exception exp)
            {
                msg = exp.Message;
                return false;
            }
        }
    }
}
