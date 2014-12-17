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
    public partial class add_drugs : CCSkinMain
    {
        public add_drugs()
        {
            InitializeComponent();
        }

        private void 添加药品_Load(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drugs_management dm = new drugs_management();
            dm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_drugs ad = new add_drugs();
            ad.Show();
        }

    
    }
}
