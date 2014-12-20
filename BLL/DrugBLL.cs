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
            try
            {
                return iDrug.GetDrugDataList();
            }
            catch
            {
                return null;
            }
        }

        //通过调用dal层方法模糊查询匹配ab的所有药品
        public DataTable GetDrugsByAB(string ab)
        {
            try
            {
                return iDrug.FindDrugByAB(ab);
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetDrugsByName(string name)
        {
            try
            {
                return iDrug.FindDrugByName(name);
            }
            catch
            {
                return null;
            }
        }

        public double GetDrugsCount()
        {
            try
            {
                return iDrug.GetDurgsCount();
            }
            catch
            {
                return 0;
            }
        }

        public bool DeleteById(int drug_id, out string msg)
        {
            msg = "删除成功！";
            try
            {
                iDrug.DeleteByID(drug_id);
            }
            catch (Exception exp)
            {
                msg = exp.Message;
                return false;
            }
            return true;
        }

        public int GetDrugTypeCount()
        {
            try
            {
                return iDrug.GetDrugTypeCount();
            }
            catch (Exception exp)
            {
                return -1;
            }
        }

        public bool AddDrug(Model.Drug drug, out string msg)
        {
            try
            {
                iDrug.Add(drug);
            }
            catch (Exception exp)
            {
                msg = exp.Message;
                return false;
            }
            msg = "成功";
            return true;
        }
    }
}
