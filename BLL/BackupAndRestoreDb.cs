using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    //数据库备份和恢复操作类
    public class BackupAndRestoreDb
    {
        IDAL.IBackupAndRestoreDb dal = DALFactory.DataAccess.CreateBackupAndRestoreDb();
        
        public void BackDb(string backupPath)
        {
            dal.BackDb(backupPath);
        }

        public void RestoreDb(string restorePath)
        {
            dal.RestoreDb(restorePath);
        }
    }
}
