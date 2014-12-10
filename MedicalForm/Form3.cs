using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace Medical
{
    public partial class Form3 : CCSkinMain
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.rtfRichTextBox1.LoadFile(@"C:\sample.rtf", RichTextBoxStreamType.RichText);
        }
    }
}
