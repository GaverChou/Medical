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
    public partial class FindPasswdUI : CCSkinMain
    {
        public FindPasswdUI()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI l = new LoginUI();
            l.Show();
        }

        private void FindPasswdUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string pass1 = pass1_txb.Text.Trim();
            string pass2 = pass2_txb.Text.Trim();
            if (pass1==""||pass2=="")
            {
                MessageBox.Show("密码为空！！");
                return;
            }else if(!pass1.Equals(pass2))
            {
                MessageBox.Show("两次输入密码不同！");
                return;
            }
            string name = name_txb.Text.Trim();
            Model.UserData data = new Model.UserData();
            data.Username = name;
            data.Idcard = idcard_txb.Text.Trim();
            string msg = "";
            if (BLL.UserBLL.GetUserBLL().FindPassWord(data, pass1, out msg))
            {
                MessageBox.Show("重置成功！！");
            }
            else if (!"".Equals(msg))
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("找回失败！未知错误！");
            }
        }
    }
}
