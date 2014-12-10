using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IBackupAndRestoreDb
    {
        //备份数据库
        void BackDb(string backupPath);
        //恢复数据库
        void RestoreDb(string restorePath);
    }
}
