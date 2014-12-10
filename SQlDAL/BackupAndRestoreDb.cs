using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using IDAL;

namespace SQlDAL
{
    public class BackupAndRestoreDb : IBackupAndRestoreDb
    {
        //备份数据库
        public void BackDb(string backupPath)
        {
            if (File.Exists(backupPath)) //判断文件是否存在
            {
                File.Delete(backupPath); //如果存在，则删除文件
            }
            string strSql = "backup database MedicalPre to disk=@backupPath"; //备份命令

            SqlParameter[] parameters = { new SqlParameter("@backupPath", SqlDbType.NVarChar, 200) };
            parameters[0].Value = backupPath;

            SqlDbHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }

        //恢复数据库
        public void RestoreDb(string restorePath)
        {
            string strSql = "Alter database MedicalPre set offline with Rollback immediate; ";
            strSql = strSql + " use master;restore database MedicalPre from disk=@restorePath with Replace; ";
            strSql = strSql + " Alter database MedicalPre Set Online with rollback Immediate";
            SqlParameter[] parameters = { new SqlParameter("@restorePath", SqlDbType.NVarChar, 200) };
            parameters[0].Value = restorePath;
            SqlDbHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }
    }
}
