using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface IPreTabDAL
    {
        DataTable GetPreDrugsById(int pid);
    }
}
