using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    public class MessageBoxBuilder
    {
        public static void buildbox(string msg, string title)
        {
            CCWin.MessageBoxEx.Show(msg, title);
        }

        public static void buildErrbox(string msg)
        {
            CCWin.MessageBoxEx.Show(msg, "错误");
        }
    }
}
