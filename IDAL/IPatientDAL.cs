using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface IPatientDAL
    {
        bool AddPatient(Model.Patient patient);
        int AddPatientRetId(Model.Patient patient);
        bool UpdatePatient(Model.Patient patient);
        bool UpdatePatientPhoto(int id,byte[] bytes);
        bool DeletePatientById(int id);
        Model.Patient GetPatientById(int pid);
        DataTable GetPatientList(int did);
        DataTable GetPatientList(int did, string like);
        DataTable GetPatientList(int did, DateTime time);
        DataSet GetPatientListForSet();
    }
}
