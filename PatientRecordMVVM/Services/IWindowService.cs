using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.Services
{
    interface IWindowService
    {
        void CreateWindow(PatientRecordDetailsModel patient);

        string GetCurrentDate();
     
    }
}
