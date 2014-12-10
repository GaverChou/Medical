using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;
using IDAL;

namespace DALFactory
{
    sealed public class DataAccess
    {
        //读取配置文件中配置的程序集名称
        private static readonly string AssemblyName = ConfigurationManager.AppSettings["DAL"];

        public static IUserDAL CreateUser()
        {
            //类名称
            string className = AssemblyName + ".UserDALImp";
            //创建对象，并进行类型转换
            return (IUserDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IUserDataDAL CreateUserData()
        {
            //类名称
            string className = AssemblyName + ".UserDataDALImp";
            //创建对象，并进行类型转换
            return (IUserDataDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDrugDAL CreateDrugDAL()
        {
            //类名称
            string className = AssemblyName + ".DrugDALImp";
            //创建对象，并进行类型转换
            return (IDrugDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IPatientDAL CreatePatientDAL()
        {
            //类名称
            string className = AssemblyName + ".PatientDALImp";
            //创建对象，并进行类型转换
            return (IPatientDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IPreTabDAL CreatePre()
        {
            //类名称
            string className = AssemblyName + ".PreTabDALImp";
            //创建对象，并进行类型转换
            return (IPreTabDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IPatientTabDAL CreatePatientTabDAL()
        {
            //类名称
            string className = AssemblyName + ".Patient_TabDALImp";
            //创建对象，并进行类型转换
            return (IPatientTabDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IEmpiricalDAL CreateEmpiricalDAL()
        {
            //类名称
            string className = AssemblyName + ".EmpiricalDALImp";
            //创建对象，并进行类型转换
            return (IEmpiricalDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IEmpiricalDrugDAL CreateEmpiricalDrugDAL()
        {
            //类名称
            string className = AssemblyName + ".EmpiricalDrugDALImp";
            //创建对象，并进行类型转换
            return (IEmpiricalDrugDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IBackupAndRestoreDb CreateBackupAndRestoreDb()
        {
            //类名称
            string className = AssemblyName + ".BackupAndRestoreDb";
            //创建对象，并进行类型转换
            return (IBackupAndRestoreDb)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
