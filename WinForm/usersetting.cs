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
    public partial class usersetting : CCSkinMain
    {
        public usersetting()
        {
            InitializeComponent();
        }
        BLL.UserBLL userBLL = BLL.UserBLL.GetUserBLL();

        private void usersetting_Load(object sender, EventArgs e)
        {
            Model.UserData data = userBLL.GetUserData(UserHelper.id);
            tb_address.Text = data.Address;
            tb_department.Text = data.Department;
            tb_gender.Text = data.Gender;
            tb_idcard.Text = data.Idcard;
            tb_name.Text = data.Username;
        }

        private void userName_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ensure_btn_Click(object sender, EventArgs e)
        {

            Model.UserData userdata = new Model.UserData();


            userdata.Username = this.tb_name.Text;
            userdata.Department = this.tb_department.Text;
            userdata.Address = this.tb_address.Text;
            userdata.Gender = this.tb_gender.Text;
            userdata.Idcard = this.tb_idcard.Text;
           
            this.Close();
        }

        private void return_but_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
