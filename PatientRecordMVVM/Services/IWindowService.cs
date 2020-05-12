using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.Services
{
    interface IWindowService
    {
        void CreateWindow(PatientRecordDetailsModel patient);

        void RefreshWindow(); 
    }
}
