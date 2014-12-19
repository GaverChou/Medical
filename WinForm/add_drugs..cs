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

        private void 添加药品_Load(object sender, EventArgs e)
        {

        }
        BLL.DrugBLL drugbll = BLL.DrugBLL.GetDrugBLLL();
        private void bt_save_Click(object sender, EventArgs e)
        {
            //将数据封装成对象
            Model.Drug drug = new Model.Drug();
            string msg = "";
            //获取每一行datagridview中的数据，通过调用bll层的AddDrugs方法依次插入数据库
            for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
            {
                drug.Drug_ab = dataGridView1.Rows[i].Cells["简码"].Value.ToString();
                drug.Drug_name = dataGridView1.Rows[i].Cells["药物"].Value.ToString();
                drug.Effect = dataGridView1.Rows[i].Cells["功效"].Value.ToString();
                drug.From_where = dataGridView1.Rows[i].Cells["产地"].Value.ToString();
                drug.In_price = Double.Parse(dataGridView1.Rows[i].Cells["进价"].Value.ToString());
                drug.Notice = dataGridView1.Rows[i].Cells["注意"].Value.ToString();
                drug.Stock =  Double.Parse(dataGridView1.Rows[i].Cells["数量"].Value.ToString()); 
                drug.Unit = dataGridView1.Rows[i].Cells["单位"].Value.ToString();
                drug.Unit_price =  Double.Parse(dataGridView1.Rows[i].Cells["单价"].Value.ToString());
                drug.Use_down =  Double.Parse(dataGridView1.Rows[i].Cells["上限"].Value.ToString());
                drug.Use_up = Double.Parse(dataGridView1.Rows[i].Cells["下限"].Value.ToString());
                drug.Wei_jin = dataGridView1.Rows[i].Cells["味经"].Value.ToString();
                if (!drugbll.AddDrug(drug,out msg))
                {
                    //若插入某一行出错则提醒用户第几行出错和出错信息
                    MessageBoxBuilder.buildErrbox("插入第"+i+"出错！"+msg);
                    return;
                }
            }
            MessageBoxBuilder.buildbox("插入成功！","ok");
        }


        private void bt_cancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drugs_management dm = new drugs_management();
            dm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_drugs ad = new add_drugs();
            ad.Show();
        }

    
    }
}
