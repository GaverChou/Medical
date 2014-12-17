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

        private void usersetting_Load(object sender, EventArgs e)
        {

        }

        private void userName_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ensure_btn_Click(object sender, EventArgs e)
        {

            Model.UserData userdata = new Model.UserData();


            userdata.Username = this.username_ttb.Text;
            userdata.Department = this.department_ttb.Text;
            userdata.Address = this.address_ttb.Text;
            userdata.Gender = this.sex_ttb.Text;
            userdata.Idcard= this.idcard_ttb.Text;
           
            this.Close();
        }

        private void return_but_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
