using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface IDrugDAL
    {
        DataTable GetDrugDataList();//换成返回值为药
        bool DeleteByID(int did);
        bool Add(Model.Drug drug);    //传入值
        bool Update(Model.Drug drug); //传入值
        DataTable FindDrugByAB(string ab); //模糊查询
        DataTable FindDrugByName(string name); //模糊查询
        Model.Drug GetDrugById(int did);
        double GetDurgsCount();
        int GetDrugTypeCount();
    }
}
