using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using Common;

namespace WinForm
{
    public partial class LoginUI : CCSkinMain
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterUI r = new RegisterUI();
            r.Show();
        }

        private void LoginUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = this.userName_txb.Text.Trim();
            string passwd = this.passwd_txb.Text.Trim();
            BLL.UserBLL instance = BLL.UserBLL.GetUserBLL();
            string msg = "";
            if (instance.Login(username, passwd,out msg))
            {
                if (remenber_ckb.Checked)
                {
                    if (!XmlRW.GetXmlRW().UpdateXML(@"user.xml", "1", username, passwd))
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                else
                {
                    XmlRW.GetXmlRW().UpdateXML(@"user.xml", "0", "", "");
                }
                UserHelper.userName = username;
                UserHelper.password = passwd;
                UserHelper.id = BLL.UserBLL.GetUserBLL().GetIdByName(username);
                this.Hide();
                MainUI r = new MainUI();
                r.Show();
             }
            else if (!"".Equals(msg))
            {
                MessageBox.Show(msg);
                this.userName_txb.Text = "";
                this.passwd_txb.Text = "";
                this.userName_txb.Focus();
            }
            else
            {
                MessageBox.Show("登录失败！");
                this.userName_txb.Text = "";
                this.passwd_txb.Text = "";
                this.userName_txb.Focus();
            }
        }

        private void forget_lb_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindPasswdUI r = new FindPasswdUI();
            r.Show();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            if("1".Equals(XmlRW.GetXmlRW().getValueByName(@"user.xml", "Check")))
            {
                userName_txb.Text = XmlRW.GetXmlRW().getValueByName(@"user.xml", "UserName");
                passwd_txb.Text = XmlRW.GetXmlRW().getValueByName(@"user.xml", "UserPwd");
                remenber_ckb.Checked = true;
            }
        }
    }
}
