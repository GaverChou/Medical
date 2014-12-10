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
    public partial class 验方管理 :CCSkinMain
    {
        BLL.EmptabBLL empTabBLL = BLL.EmptabBLL.GetEmptabBLL();
        BLL.EmpDrugBLL empDrugs = BLL.EmpDrugBLL.GetDrugBLLL();
        DataTable dataEmp;
        DataTable dataDrugs;
        DataSet myds;
        CurrencyManager myBind;//绑定管理器对象，用来使绑定到同一个数据源的多个控件保持同步
        bool isFirst = true;

        public 验方管理()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            this.text_name.DataBindings.Clear();
            this.text_method.DataBindings.Clear();
            this.text_function.DataBindings.Clear();
            this.text_from.DataBindings.Clear();
            this.text_cure.DataBindings.Clear();
            this.text_code.DataBindings.Clear();
            isFirst = true;
        }

        public void Fill()
        {
            myds = new DataSet();
            if ("".Equals(ab))
            {
                dataEmp = empTabBLL.GetAllEmpTab();
                dataDrugs = empDrugs.GetEmpDrugs();
            }
            else
            {
                dataEmp = empTabBLL.GetAllEmpTabByAb(ab);
                dataDrugs = empDrugs.GetEmpDrugsByAb(ab);
            }
            myds.Tables.Add(dataEmp);
            myds.Tables.Add(dataDrugs);
            //建立两个表之间的联系
            DataRelation r;
            DataColumn dc1 = new DataColumn();
            DataColumn dc2 = new DataColumn();
            //获取两个表的关联字段，建立联系
            dc1 = myds.Tables[0].Columns["em_id"];
            dc2 = myds.Tables[1].Columns["em_id"];
            r = new DataRelation("empDrugs", dc1, dc2);
            myds.Relations.Add(r);

            //建立主表的绑定源
            BindingSource masterBindingSource = new BindingSource(myds, myds.Tables[0].TableName);
            //建立从表的绑定源
            BindingSource slaveBindingSource = new BindingSource(masterBindingSource, "empDrugs");

            dGV_recipe.DataSource = masterBindingSource;
            dGV_drug.DataSource = slaveBindingSource;
            dGV_drug.Columns[0].Visible = false;
            //调整所有列的宽度以适应其所有单元格（包括标题单元格）的内容。 
            dGV_recipe.AutoResizeColumns();
            //设定列宽为自动适合列中所有单元格（包括标题单元格）的内容。
            dGV_drug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            myBind = (CurrencyManager)this.BindingContext[masterBindingSource];
            if (isFirst)
            {
                //以下为各个控件进行数据绑定 
                this.text_name.DataBindings.Add(new Binding("Text", masterBindingSource, "em_name"));
                this.text_method.DataBindings.Add(new Binding("Text", masterBindingSource, "fangjie"));
                this.text_function.DataBindings.Add(new Binding("Text", masterBindingSource, "effect"));
                this.text_from.DataBindings.Add(new Binding("Text", masterBindingSource, "from_where"));
                this.text_cure.DataBindings.Add(new Binding("Text", masterBindingSource, "cure"));
                this.text_code.DataBindings.Add(new Binding("Text", masterBindingSource, "em_ab"));
            }
        }

        private void 验方管理_Load(object sender, EventArgs e)
        {
            Fill();
            isFirst = false;
        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            Clear();
            Model.EmpTab empTab = new Model.EmpTab();
            empTab.Em_name = this.text_name.Text;
            empTab.Effect = this.text_method.Text;
            empTab.Fangjie = this.text_function.Text;
            empTab.From_where = this.text_from.Text;
            empTab.Cure = this.text_cure.Text;
            empTab.Em_ab = this.text_code.Text;
            empTab.Minus_and_add = "无";
            empTab.Apply = "无";
            if (empTabBLL.UpdateEmpTab(empTab))
            {
                MessageBox.Show("更新成功！");
            }
            Fill();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            ParseEmpTab();
        }

        private void ParseEmpTab()
        {
            Model.EmpTab empTab = new Model.EmpTab();
            empTab.Em_name = this.text_name.Text;
            empTab.Effect = this.text_method.Text;
            empTab.Fangjie = this.text_function.Text;
            empTab.From_where = this.text_from.Text;
            empTab.Cure = this.text_cure.Text;
            empTab.Em_ab = this.text_code.Text;
            empTab.Minus_and_add = "无";
            empTab.Apply = "无";
            if (empTabBLL.UpdateEmpTab(empTab))
            {
                MessageBox.Show("更新成功！");
            }
            Fill();
        }
        string ab = "";
        private void bt_search_Click(object sender, EventArgs e)
        {
            Clear();
            ab = txb_search.Text.Trim();
            Fill();
        }
    }
}
