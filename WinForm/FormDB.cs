using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CCWin;

namespace WinForm
{
    public partial class FormDB : CCSkinMain
    {
        public FormDB()
        {
            InitializeComponent();
        }

        string backupPath = ""; //备份路径
        string restorePath = ""; //恢复路径
        BLL.BackupAndRestoreDb bll = new BLL.BackupAndRestoreDb();

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files (*,bak)|*.bak";
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sfdlgBackup.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (backupPath == "")
            {
                MessageBoxBuilder.buildbox("请先选择数据库备份路径", "提示");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bll.BackDb(backupPath);
                MessageBoxBuilder.buildbox("数据库备份成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBoxBuilder.buildErrbox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnRestroePath_Click(object sender, EventArgs e)
        {
            ofdlgRestore.FilterIndex = 1;
            ofdlgRestore.FileName = "";
            ofdlgRestore.Filter = "Bak Files (*.bak)|*.bak";
            if (ofdlgRestore.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofdlgRestore.FileName.ToString();
                txtRestore.ReadOnly = true;
            }
            restorePath = txtRestore.Text.Trim();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (restorePath == "")
            {
                MessageBoxBuilder.buildbox("请先选择数据库恢复路径", "提示");
                return;
            }           
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bll.RestoreDb(restorePath);
                MessageBoxBuilder.buildbox("数据库恢复成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBoxBuilder.buildErrbox(ex.Message);
            }
            finally
            {                
                this.Cursor = Cursors.Arrow;
            }
        }
    }
}
