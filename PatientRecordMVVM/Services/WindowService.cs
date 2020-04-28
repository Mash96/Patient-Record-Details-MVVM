using PatientRecordMVVM.Views;
using PatientRecordMVVM.Model;
using PatientRecordMVVM.ViewModels;
using System.Windows;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {
        //private HomeCareMain m_homeCare;

        public WindowService()
        {
            
        }
        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreviewWindow printPreviewWindow = new PrintPreviewWindow(patient);
            printPreviewWindow.Show();
        }
    }
}
