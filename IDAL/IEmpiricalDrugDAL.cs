using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface IEmpiricalDrugDAL
    {
        DataTable GetDrugListByID();
        DataTable GetDrugListByAb(string ab);
        bool DeleteByID(int did);
        bool Add();    //传入值
        bool Update(); //传入值
    }
}
