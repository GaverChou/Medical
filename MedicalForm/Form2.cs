using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace Medical
{
    public partial class Form2 : CCSkinMain
    {
        public Form2()
        {
            InitializeComponent();
        }

        BLL.DrugBLL bll = BLL.DrugBLL.GetDrugBLLL();

        public void Fill()
        {
            //this.dataGridView1.DataSource = bll.GetAllDrug();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Fill();
            this.dv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
        }

        private void skinColorSelectPanel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dv = new DataGridView();
            //dv.Parent = this.dataGridView1;
            //dv.Location = new Point((e.RowIndex + 1) * 10, (e.ColumnIndex + 1) * 10);
            //dv.Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dv = new DataGridView();
            //dv.Parent = this.dataGridView1;
            //dv.Location = new Point((e.RowIndex+1) * 10, (e.ColumnIndex +1)* 10);
            //dv.Show();
            dv.Hide();
        }

        DataGridView dv = new DataGridView();
        
        BLL.DrugBLL instance = BLL.DrugBLL.GetDrugBLLL();
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DataGridView dv = new DataGridView();
            if (e.ColumnIndex == 1)
            {
                dv.Parent = this.dataGridView1;
                dv.RowHeadersVisible = false;
                dv.Location = new Point(170, (e.RowIndex + 1) * 20);
                dv.DataSource = instance.GetDrugsByAB("A");
                dv.Show();
            }
        }

        //DataTable dt = new DataTable();
        private void dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < dv.Rows.Count)
            {
                //DataRow dr = dt.NewRow();
                dataGridView1.Rows[0].Cells[0].Value = dv.Rows[index].Cells[0].Value;
                dataGridView1.Rows[0].Cells[1].Value = dv.Rows[index].Cells[1].Value;
                dataGridView1.Rows[0].Cells[2].Value = dv.Rows[index].Cells[2].Value;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            //string value = dv.CurrentCell.Value.ToString().Trim();
            //dv.DataSource = instance.GetDrugsByAB(value);
            //dv.Show();
        }
    }
}
