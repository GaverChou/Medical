using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class PatientBLL
    {
        IDAL.IPatientDAL pa = DALFactory.DataAccess.CreatePatientDAL();
        IDAL.IPatientTabDAL paT = DALFactory.DataAccess.CreatePatientTabDAL();
        private static PatientBLL instance;

        private PatientBLL()
        {
        }

        public static PatientBLL GetPatientBLL()
        {
            if (instance == null)
            {
                instance = new PatientBLL();
            }
            return instance;
        }

        public bool AddPatient(Model.Patient patient,Model.Patient_Tab patient_tab,out string msg)
        {
             msg = "";
             if (!CheckPatientData(patient,out msg))
             {
                 return false;
             }
            int id = pa.AddPatientRetId(patient);
            if (id!=-1)
            {
                patient_tab.Pid = id;
                if (!CheckPatientTabData(patient_tab,out msg))
                {
                    return false;
                }
                if ((paT.AddPatientTab(patient_tab)))
                {
                    return true;
                }else
                {
                    pa.DeletePatientById(id);
                    msg = "插入病人诊断信息失败!";
                    return false;
                }
            }
            msg = "插入病人信息失败！";
            return false;
        }

        private bool CheckPatientData(Model.Patient patient, out string msg)
        {
            msg = "";
            if (patient == null)
            {
                msg = "未填入用户";
                return false;
            }
            else if (patient.D_ID<0)
            {
                msg = "医生信息出错！";
                return false;
            }
            else if ("".Equals(patient.Gender) || patient.Gender == null)
            {
                msg = "未填入性别信息";
                return false;
            }
            else if ("".Equals(patient.Idcard) || patient.Idcard == null)
            {
                msg = "未填入身份证信息";
                return false;
            }
            else if (patient.Old <= 0)
            {
                msg = "未填入年龄信息";
                return false;
            }
            else if ("".Equals(patient.P_name) || patient.P_name == null)
            {
                msg = "未填入病人姓名";
                return false;
            }
            else if ("".Equals(patient.Tel) || patient.Tel == null)
            {
                msg = "未填入联系方式";
                return false;
            }
            return true;
        }

        private bool CheckPatientTabData(Model.Patient_Tab patient_tab,out string msg)
        {
            msg = "";
            if (patient_tab == null)
            {
                msg = "用户诊断信息为空";
                return false;
            }
            else if (patient_tab.Chufang_count<=0)
            {
                msg = "处方记数出错！";
                return false;
            }
            else if ("".Equals(patient_tab.Xianbingshi) || patient_tab.Xianbingshi == null)
            {
                msg = "未填入病人病史";
                return false;
            }
            else if ("".Equals(patient_tab.Zhengduan) || patient_tab.Zhengduan == null)
            {
                msg = "未填入病人诊断信息";
                return false;
            }
            return true;
        }

        public DataTable GetPatientList(int id)
        {
            return pa.GetPatientList(id);
        }

        public DataTable GetPatientList(int id,string like)
        {
            return pa.GetPatientList(id,like);
        }

        public DataTable GetPatientList(int id,DateTime time)
        {
            return pa.GetPatientList(id,time);
        }

        public bool UpdatePatientPhoto(int pid, byte[] bytes)
        {
            return pa.UpdatePatientPhoto(pid,bytes);
        }
    }
}
