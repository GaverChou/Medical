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
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            this.bingli_rbx.LoadFile(@"C:\sample.rtf", RichTextBoxStreamType.RichText);
            this.dv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            this.lb_username.Text = UserHelper.userName;
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

        private void drug_tab_dv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            count = e.RowIndex;
            int row = e.ColumnIndex;
            if (row == 1)
            {
                dv.Parent = this.drug_tab_dv;
                dv.RowHeadersVisible = false;
                dv.Location = new Point(170, (e.RowIndex + 1) * 20);
                //drug_tab_dv.Rows[count].Cells[row].Value.ToString()
                dv.DataSource = instance.GetDrugsByAB("A");
                dv.Show();
            }
        }

        private void drug_tab_dv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dv.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.drug_tab_dv.Rows.Clear();
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

        private void baocun_btn_Click(object sender, EventArgs e)
        {
            Model.Patient patient = new Model.Patient();
            Model.Patient_Tab patient_tab = new Model.Patient_Tab();
            patient.P_name = tb_pname.Text.Trim();
            try
            {
                patient.Old = Convert.ToInt16(tb_old.Text.Trim());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            patient.Tel = tb_tel.Text.Trim();
            patient.Idcard = tb_idcard.Text.Trim();
            patient.D_ID = 10000;
            if (FileName != null && !"".Equals(FileName))
            {
                if ((pictureBox1.Image != null))
                    pictureBox1.Image.Dispose();
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
            if (patientInstance.AddPatient(patient, patient_tab, out msg))
            {
                MessageBox.Show("保存成功！");
            }
            else if (!"".Equals(msg))
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("未知错误！插入失败!");
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

        private void drug_tab_dv_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

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
            pictureBox1.Image = Image.FromFile(FileName, true);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            usersetting us = new usersetting();
            us.Show();
        }


        
    }
}
