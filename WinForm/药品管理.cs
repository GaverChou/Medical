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
    public partial class 药品管理 : CCSkinMain
    {
        public 药品管理()
        {
            InitializeComponent();
        }
        BLL.DrugBLL drugBLL = BLL.DrugBLL.GetDrugBLLL();

        private void 药品管理_Load(object sender, EventArgs e)
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
    }
}
