using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IUserDataDAL
    {
        string findIdCardByName(string uid);

        bool addUserData(Model.UserData userData);

        bool updateUserData(Model.UserData userData);

        Model.UserData GetDataById(int uid);
    }
}
