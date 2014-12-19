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
            //两次密码输入不一致则提醒用户说明不一致
            if (pass1==""||pass2=="")
            {
                MessageBoxBuilder.buildErrbox("密码为空！！");
                return;
            }else if(!pass1.Equals(pass2))
            {
                MessageBoxBuilder.buildErrbox("两次输入密码不同！");
                return;
            }
            //将用户输入的信息封装成model类传给BLL层
            string name = name_txb.Text.Trim();
            Model.UserData data = new Model.UserData();
            data.Username = name;
            data.Idcard = idcard_txb.Text.Trim();
            string msg = "";
            //重置成功后返回信息提醒用户重置情况
            if (BLL.UserBLL.GetUserBLL().FindPassWord(data, pass1, out msg))
            {
                MessageBoxBuilder.buildbox("重置成功！！","成功");
            }
            else if (!"".Equals(msg))
            {
                MessageBoxBuilder.buildErrbox(msg);
            }
            else
            {
                MessageBoxBuilder.buildErrbox("找回失败！未知错误！");
            }
        }
    }
}
