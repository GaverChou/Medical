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
            //若两次输入的密码不一致则打回去重做，并弹出对话框提示用户错误信息
            if (passwd1==""||passwd1=="")
            {
                MessageBoxBuilder.buildErrbox("密码为空！！");
                return;
            }else if(!passwd1.Equals(passwd2))
            {
                MessageBoxBuilder.buildErrbox("两次输入密码不同！");
                return;
            }
            //通过Model包下的user雨userdata将用户登录信息跟用户信息传给BLL层
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
            if (userBLL.Register(user, userdata,out msg)) //userBLL将user跟userdata插入到数据库
            {
                MessageBoxBuilder.buildbox("注册成功！","ok");//成功则弹出对话框提示用户注册成功
            }
                //若用户传入的信息不合格，或者再插入数据的时候出现了异常，则弹出对话框提示用户出错信息
            else if (!"".Equals(msg))
            {
                MessageBoxBuilder.buildErrbox(msg);
            }
            else
            {
                MessageBoxBuilder.buildErrbox("注册失败！");
            }

        }
    }
}
