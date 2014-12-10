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
    public partial class RegisterUI : CCSkinMain
    {
        public RegisterUI()
        {
            InitializeComponent();
        }

        private void RegisterUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI l = new LoginUI();
            l.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string passwd1 = this.passwd_txb_1.Text.Trim();
            string passwd2 = this.passwd_txb_2.Text.Trim();
            if (passwd1==""||passwd1=="")
            {
                MessageBox.Show("密码为空！！");
                return;
            }else if(!passwd1.Equals(passwd2))
            {
                MessageBox.Show("两次输入密码不同！");
                return;
            }
            Model.User user = new Model.User();
            Model.UserData userdata = new Model.UserData();
            user.UserName = this.name_txb.Text.Trim();
            user.Password = passwd1;
            userdata.Username = this.name_txb.Text.Trim();
            userdata.Department = this.kebie_txb.Text.Trim();
            userdata.Address = this.address_txb.Text.Trim();
            userdata.Idcard = this.idcard_txb.Text.Trim();
            userdata.Gender = this.gender_cb.Text.Trim();

            string msg = "";
            BLL.UserBLL userBLL = BLL.UserBLL.GetUserBLL();
            if (userBLL.Register(user, userdata,out msg))
            {
                MessageBox.Show("注册成功！");
            }
            else if (!"".Equals(msg))
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("注册失败！");
            }

        }
    }
}
