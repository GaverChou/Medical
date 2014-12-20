using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Drawing.Printing;

namespace WinForm
{
    public partial class MainUI : CCSkinMain
    {
        DataGridView dv = new DataGridView();
        int count = 0;
        Font printFont;
        BLL.DrugBLL instance = BLL.DrugBLL.GetDrugBLLL();
        BLL.PatientBLL patientInstance = BLL.PatientBLL.GetPatientBLL();
        BLL.EmptabBLL empBLL = BLL.EmptabBLL.GetEmptabBLL();
        BLL.EmpDrugBLL empDrugBLL = BLL.EmpDrugBLL.GetDrugBLLL();

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            this.bingli_rbx.LoadFile(@"sample.rtf", RichTextBoxStreamType.RichText);
            this.dv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            this.lb_username.Text = UserHelper.userName;
            tb_old.DataBindings.Add("Text", tb_pname, "Text");//bangding
            this.drug_tab_dv.AutoGenerateColumns = false;
            DataTable tab = empBLL.GetAllEmpTab();
            //this.cm_emp.DataSource = tab;
            //cm_emp.DisplayMember = "em_name";//这是text值
            //cm_emp.ValueMember = "em_name";
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                cm_emp.Items.Add(tab.Rows[i]["em_name"]);
            }
        }

        private void dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < dv.Rows.Count)
            {
                //DataRow dr = dt.NewRow();
                drug_tab_dv.Rows[count].Cells[0].Value = dv.Rows[index].Cells[0].Value;
                drug_tab_dv.Rows[count].Cells[1].Value = dv.Rows[index].Cells[1].Value;
                drug_tab_dv.Rows[count].Cells[3].Value = dv.Rows[index].Cells[2].Value;
                drug_tab_dv.Rows[count].Cells[4].Value = dv.Rows[index].Cells[3].Value;
                drug_tab_dv.EndEdit();
            }
        }

        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void patient_control_btn_Click(object sender, EventArgs e)
        {
            Patient r = new Patient();
            r.Show();
        }

        private void drug_tab_dv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dv.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (this.drug_tab_dv.DataSource != null)
            {
                this.drug_tab_dv.DataSource = null;
            }
            else
            {
                this.drug_tab_dv.Rows.Clear();
            }
        }

        private void print_btn_Click_1(object sender, EventArgs e)
        {
            printFont = new Font("微软雅黑", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            // 打印文档
            pd.Print();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //ev.Graphics.DrawString(this.bingli_rbx.Text);
            //ev.HasMorePages = true;
        }

        public void ShowPhoto()
        {
            if ((pictureBox1.Image != null))
            {
                pictureBox1.Image = null;
                if (!"".Equals(FileName) && FileName != null)
                    pictureBox1.Image = Image.FromFile(FileName, true);
            }
            else if (!"".Equals(FileName) && FileName != null)
                pictureBox1.Image = Image.FromFile(FileName, true);
        }

        private void baocun_btn_Click(object sender, EventArgs e)
        {
            //将输入的信息封装成类对象，传入bll层
            Model.Patient patient = new Model.Patient();
            Model.Patient_Tab patient_tab = new Model.Patient_Tab();
            patient.P_name = tb_pname.Text.Trim();
            //年龄信息出错，提醒用户
            try
            {
                patient.Old = Convert.ToInt16(tb_old.Text.Trim());
            }
            catch (Exception exp)
            {
                MessageBoxBuilder.buildbox((exp.Message), "错误！");
                return;
            }
            patient.Tel = tb_tel.Text.Trim();
            patient.Idcard = tb_idcard.Text.Trim();
            patient.D_ID = UserHelper.id;
            //用与得到用户转入的病人照片信息
            if (FileName != null && !"".Equals(FileName))
            {
                if ((pictureBox1.Image != null))
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                patient.Thumb = Common.Util.GetImageByte(FileName);
            }
            if (rb_man.Checked)
            {
                patient.Gender = "男";
            }
            else if (rb_woman.Checked)
            {
                patient.Gender = "女";
            }
            else
            {
                patient.Gender = "不详";
            }
            patient_tab.Chufang_count = Convert.ToInt32(tb_jishu.Text.Trim());
            patient_tab.Xianbingshi = tb_bingshi.Text.Trim();
            patient_tab.Zhengduan = tb_zhenduan.Text.Trim();
            string msg = "";
            //添加处方信息与病人信息
            if (patientInstance.AddPatient(patient, patient_tab, out msg))
            {
                MessageBoxBuilder.buildbox("保存成功！", "ok");
                ShowPhoto();
            }
            else if (!"".Equals(msg))
            {
                MessageBoxBuilder.buildbox(msg,"错误");
            }
            else
            {
                MessageBoxBuilder.buildbox("未知错误！插入失败!","错误");
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            prescription_management r = new prescription_management();
            r.Show();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            drugs_management r = new drugs_management();
            r.Show();
        }

        private void skinButton6_Click(object sender, EventArgs e)
        {
            FormDB fdb = new FormDB();
            fdb.Show();
        }

        string FileName; //变量FileName准备记录"路径+文件名" 
        public string btnImagePressed; //定义一个变量用于监视是否曾经找到过照片 
        public OpenFileDialog opFileDial = new OpenFileDialog(); //定义一个对话框对象opFileDial

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //显示打开文件对话框 
            opFileDial.ShowDialog();
            //从显示文件对话框中选定图像文件赋给变量FileName 
            FileName = opFileDial.FileName;
            //用PictureBox控件显示选中的图像文件 
            if(!"".Equals(FileName)&&FileName!=null)
                pictureBox1.Image = Image.FromFile(FileName, true);
        }

        private void drug_tab_dv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            count = e.RowIndex;
            int row = e.ColumnIndex;
            if (row == 1)
            {
                //string data = drug_tab_dv.Rows[count].Cells[1].Value.ToString();
                //    if (!"".Equals(data) && data != null)
                //    {
                dv.Parent = this.drug_tab_dv;
                dv.RowHeadersVisible = false;
                dv.Location = new Point(170, (e.RowIndex + 1) * 20);
                //drug_tab_dv.Rows[count].Cells[row].Value.ToString()
                dv.DataSource = instance.GetDrugsByAB("A");
                dv.Show();
            }
        }


        private void drug_tab_dv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //count = e.RowIndex;
            //this.label7.Text = "" + count;
            //int row = e.ColumnIndex;
            //if (row == 1 )
            //{
            //    string data = drug_tab_dv.Rows[count].Cells[1].Value.ToString();
            //    if (!"".Equals(data) && data != null)
            //    {
            //        dv.Parent = this.drug_tab_dv;
            //        dv.RowHeadersVisible = false;
            //        dv.Location = new Point(170, (e.RowIndex + 1) * 20);
            //        //drug_tab_dv.Rows[count].Cells[row].Value.ToString()
            //        dv.DataSource = instance.GetDrugsByAB(drug_tab_dv.Rows[count].Cells[1].Value.ToString());
            //        dv.Show();
            //    }
            //}
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            usersetting us = new usersetting();
            us.Show();
        }

        private void cm_emp_SelectedValueChanged(object sender, EventArgs e)
        {
            this.drug_tab_dv.DataSource = empDrugBLL.GetEmpDrugsByName(this.cm_emp.Text);
        }

    }
}
