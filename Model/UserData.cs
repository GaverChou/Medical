using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class UserData
    {
        public UserData()
        {}

        #region Model

        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string idcard;

        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private DateTime lastLoginTime;

        public DateTime LastLoginTime
        {
            get { return lastLoginTime; }
            set { lastLoginTime = value; }
        }
        #endregion
    }
}
