using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface IEmpiricalDAL
    {
        DataTable GetEmpDataList();
        DataTable GetEmpDataListByAb(string ab);
        bool DeleteByID(string did);
        bool Add(Model.EmpTab empTab);    //传入值
        bool Update(Model.EmpTab empTab); //传入值
    }
}
