using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
namespace WinForm
{
    public partial class drugs_management : CCSkinMain
    {
        public drugs_management()
        {
            InitializeComponent();
        }
        BLL.DrugBLL drugBLL = BLL.DrugBLL.GetDrugBLLL();

        private void drugs_management_Load(object sender, EventArgs e)
        {
            drugs_dvg.DataSource = drugBLL.GetAllDrug();
            tx_count.Text = Convert.ToString(drugBLL.GetDrugsCount());
            tb_count.Text = Convert.ToString(drugBLL.GetDrugTypeCount());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            drugs_dvg.DataSource = drugBLL.GetDrugsByName(tx_search.Text.Trim());
        }
        private int drug_id;

        private void drugs_dvg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index < drugs_dvg.RowCount&&index>=0)
            {
                string v = drugs_dvg.Rows[index].Cells[0].Value.ToString();
                if("".Equals(v)||v==null){
                    return;
                }
                drug_id = Convert.ToInt16(v);
            }
        }

        public static drugs_management dm = new drugs_management();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_drugs.ad.Show();
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            string msg = "";
            if (drugBLL.DeleteById(drug_id, out msg))
            {
                MessageBoxBuilder.buildbox(msg, "ok");
            }
            else
            {
                MessageBoxBuilder.buildErrbox(msg);
            }
        }
        string backupPath = ""; //备份路径
        private void btn_export_Click(object sender, EventArgs e)
        {
            string msg = "";
            DataTable t = drugBLL.GetAllDrug();
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files (*,xls)|*.xls";
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                backupPath = sfdlgBackup.FileName.ToString();
            }
            if (!"".Equals(backupPath))
            {
                Common.Util.ExportXLS(backupPath,t,out msg);
            }
            MessageBoxBuilder.buildbox(msg ," ");
        }
    }
}
