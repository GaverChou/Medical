using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IUserDAL
    {
            //判断用户名、密码是否正确
            bool Login(string userName, string userPassword);
            //更新用户密码
            bool Update(Model.User model);
            //增加用户
            bool AddUser(Model.User user);
            int FindIdByName(string name);
            int AddUserAndRetId(Model.User user);
            bool DeleteByID(int uid);
    }
}
