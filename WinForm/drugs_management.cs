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
            if (index < drugs_dvg.RowCount)
            {
                drug_id = Convert.ToInt16(drugs_dvg.Rows[index].Cells[0].Value);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            add_drugs ads = new add_drugs();
            ads.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drugs_management dmt = new drugs_management();
            dmt.Show();
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }
}
