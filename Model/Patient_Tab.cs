using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Patient_Tab
    {
        private string xianbingshi;

        public string Xianbingshi
        {
            get { return xianbingshi; }
            set { xianbingshi = value; }
        }

        private string zhengduan;

        public string Zhengduan
        {
            get { return zhengduan; }
            set { zhengduan = value; }
        }

        private int pid;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        private int chufang_count;

        public int Chufang_count
        {
            get { return chufang_count; }
            set { chufang_count = value; }
        }
    }
}
