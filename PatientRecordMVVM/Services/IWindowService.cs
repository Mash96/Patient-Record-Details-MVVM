using System;
using System.Collections.Generic;
using System.Text;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.Services
{
    interface IWindowService
    {
        void CreateWindow(PatientRecordDetailsModel patient);
    }
}
