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
            if (instance.Login(username, passwd,out msg)) //通过调用UserBLL的Login方法检测用户名密码是否正确
            {
                if (remenber_ckb.Checked)                   //若成功登陆，则检测是否勾选记住密码
                {
                    //勾选则将用户名密码保存到user.xml文件中，该文件为xml文件
                    if (!XmlRW.GetXmlRW().UpdateXML(@"user.xml", "1", username, passwd))
                    {
                        MessageBoxBuilder.buildbox("保存失败！","错误！");
                    }
                }
                else
                {
                    XmlRW.GetXmlRW().UpdateXML(@"user.xml", "0", "", "");//没有勾选则将上次保存记录删除
                }
                UserHelper.userName = username;
                UserHelper.password = passwd; //将用户名密码保存为static全局变量，让其能在程序任意地方调用
                UserHelper.id = BLL.UserBLL.GetUserBLL().GetIdByName(username);
                this.Hide();
                MainUI r = new MainUI();  //将界面切换至主界面
                r.Show();
             }
                //检测失败则给用户显示错误信息
            else if (!"".Equals(msg))
            {
                MessageBoxBuilder.buildbox(msg, "错误！");
                this.userName_txb.Text = "";
                this.passwd_txb.Text = "";
                this.userName_txb.Focus();
            }
            else
            {
                MessageBoxBuilder.buildbox("登录失败！", "错误！");
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
