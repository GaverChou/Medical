using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.IO;

namespace WinForm
{
    public partial class Patient : CCSkinMain
    {
        DataTable objDTable = new DataTable(); //数据集
        CurrencyManager myBind;//绑定管理器对象，用来使绑定到同一个数据源的多个控件保持同步
        private int switch_i = 0;
        private bool isFirst = true;

        public Patient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Fill()
        {
            if (switch_i == 0&&!"".Equals(name_find_tb.Text.Trim()))
            {
                objDTable = BLL.PatientBLL.GetPatientBLL().GetPatientList(10000,name_find_tb.Text.Trim());
            }
            else if (switch_i == 1 && date_time.Value != null)
            {
                objDTable = BLL.PatientBLL.GetPatientBLL().GetPatientList(10000, date_time.Value);
            }
            else
            {
                objDTable = BLL.PatientBLL.GetPatientBLL().GetPatientList(10000);
            }
            this.patient_dwg.DataSource = objDTable;
            if (isFirst)
            {
                myBind = (CurrencyManager)this.BindingContext[objDTable];
                //以下为各个控件进行数据绑定 
                name_tb.DataBindings.Add(new Binding("Text", objDTable, "p_name"));
                id_tb.DataBindings.Add(new Binding("Text", objDTable, "pid"));
                gender_tb.DataBindings.Add(new Binding("Text", objDTable, "gender"));
                old_tb.DataBindings.Add(new Binding("Text", objDTable, "old"));
                phone_tb.DataBindings.Add(new Binding("Text", objDTable, "tel"));
                zhenduan_tb.DataBindings.Add(new Binding("Text", objDTable, "zhenduan"));
                bingshi_bx.DataBindings.Add(new Binding("Text", objDTable, "xianbingshi"));
                pb_patient.DataBindings.Add(new Binding("Image", objDTable, "thumb",true));
                doc_tb.Text = "10000";
            }
            index = 0;
            if (objDTable.Rows.Count>0 && objDTable.Rows[0]["pid"] != null && objDTable.Rows[0]["pid"].ToString() != "")
            {
                pid = Convert.ToInt16(objDTable.Rows[0]["pid"]);
                chufang_bx.Text = BLL.PreBLL.GetPreBLL().GetPreDrugsById(pid);
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            Fill();
            isFirst = false;
        }

        int pid;
        int index;
        private void patient_dwg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (objDTable.Rows.Count-1>index&&objDTable.Rows[index]["pid"] != null && !"".Equals(objDTable.Rows[index]["pid"].ToString()))
            {
                pid = Convert.ToInt16(objDTable.Rows[index]["pid"]);
                chufang_bx.Text = BLL.PreBLL.GetPreBLL().GetPreDrugsById(pid);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.date_time.Visible = false;
                    this.name_find_tb.Visible = true;
                    switch_i = 0;
                    break;
                case 1:
                    this.date_time.Visible = true;
                    this.name_find_tb.Visible = false;
                    switch_i = 1;
                    break;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Fill();
        }

        string FileName; //变量FileName准备记录"路径+文件名" 
        public string btnImagePressed; //定义一个变量用于监视是否曾经找到过照片 
        public OpenFileDialog opFileDial = new OpenFileDialog(); //定义一个对话框对象opFileDial

        private void pb_patient_Click(object sender, EventArgs e)
        {
            //显示打开文件对话框 
            opFileDial.ShowDialog();
            //从显示文件对话框中选定图像文件赋给变量FileName 
            FileName = opFileDial.FileName;
            //用PictureBox控件显示选中的图像文件 
            pb_patient.Image = Image.FromFile(FileName,true);
            
            //if (BLL.PatientBLL.GetPatientBLL().UpdatePatientPhoto(pid, B))
            //{
            //    MessageBox.Show("上传成功！");
            //}
            //else
            //{
            //    MessageBox.Show("上传失败！");
            //}
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (FileName != null && !"".Equals(FileName))
            {
              if ((pb_patient.Image != null))
                  pb_patient.Image.Dispose();
               byte[] b = Common.Util.GetImageByte(FileName);
               if (BLL.PatientBLL.GetPatientBLL().UpdatePatientPhoto(pid, b))
               {
                   MessageBox.Show("上传成功！");
                   pb_patient.Image = null;
                   Fill();
               }
               else
               {
                   MessageBox.Show("上传失败！");
               }
            }
        }

        
    }
}
