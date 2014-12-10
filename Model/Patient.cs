using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Model
{
    public class Patient
    {
        public Patient() { }

        private string p_name;

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private int old;

        public int Old
        {
            get { return old; }
            set { old = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string idcard;

        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }

        private int d_id;
        public int D_ID
        {
            get{ return d_id; }
            set{ d_id = value; }
        }

        private byte[] thumb;

        public byte[] Thumb
        {
            get { return thumb; }
            set { thumb = value; }
        }

        private int pid;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public static Patient ParsePatient(DataRowCollection dataRow,int index)
        {
            try{
                Patient patient = new Patient();
                patient.D_ID = Convert.ToInt16(dataRow[index]["d_id"].ToString());
                patient.Gender = dataRow[index]["gender"].ToString();
                patient.Old = Convert.ToInt16(dataRow[index]["old"]);
                patient.P_name = dataRow[index]["p_name"].ToString();
                patient.Pid = Convert.ToInt16(dataRow[index]["pid"]);
                patient.Tel = dataRow[index]["tel"].ToString();
                return patient;
            }catch(Exception exp){
                return null;
            }
        }
    }
}
