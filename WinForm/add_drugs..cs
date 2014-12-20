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
    public partial class add_drugs : CCSkinMain
    {
        public add_drugs()
        {
            InitializeComponent();
        }

        BLL.DrugBLL drugbll = BLL.DrugBLL.GetDrugBLLL();

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            drugs_management.dm.Show();
        }
        public static add_drugs ad = new add_drugs();

        private void bt_save_Click_1(object sender, EventArgs e)
        {
            Model.Drug drug = new Model.Drug();
            string msg = "";
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                drug.Drug_ab = dataGridView1.Rows[i].Cells["简码"].Value.ToString();
                drug.Drug_name = dataGridView1.Rows[i].Cells["药物"].Value.ToString();
                drug.Effect = dataGridView1.Rows[i].Cells["功效"].Value.ToString();
                drug.From_where = dataGridView1.Rows[i].Cells["产地"].Value.ToString();
                drug.In_price = Double.Parse(dataGridView1.Rows[i].Cells["进价"].Value.ToString());
                drug.Notice = dataGridView1.Rows[i].Cells["注意"].Value.ToString();
                drug.Stock = Double.Parse(dataGridView1.Rows[i].Cells["数量"].Value.ToString());
                drug.Unit = dataGridView1.Rows[i].Cells["单位"].Value.ToString();
                drug.Unit_price = Double.Parse(dataGridView1.Rows[i].Cells["单价"].Value.ToString());
                drug.Use_down = Double.Parse(dataGridView1.Rows[i].Cells["上限"].Value.ToString());
                drug.Use_up = Double.Parse(dataGridView1.Rows[i].Cells["下限"].Value.ToString());
                drug.Wei_jin = dataGridView1.Rows[i].Cells["味经"].Value.ToString();
                if (!drugbll.AddDrug(drug, out msg))
                {
                    MessageBoxBuilder.buildErrbox("插入第" + i + "出错！" + msg);
                }
            }
            MessageBoxBuilder.buildbox("插入成功！", "ok");
        }
        string restorePath = ""; //恢复路径
        private void btn_import_Click(object sender, EventArgs e)
        {
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files (*,xls)|*.xls";
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                restorePath = sfdlgBackup.FileName.ToString();
            }
            if(!"".Equals(restorePath))
            {
                dataGridView1.DataSource = Common.Util.ImportXLS(restorePath);
            }
        }

        private void bt_cancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    
    }
}
