using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IPatientTabDAL
    {
        bool DeleteById(int pid);

        bool AddPatientTab(Model.Patient_Tab pat_tab);
    }
}
