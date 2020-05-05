using PatientRecordMVVM.Views;
using PatientRecordMVVM.ViewModels;
using System.Windows;
using PatientRecordMVVM.Models;

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
            printPreviewWindow.ShowDialog();
        }
    }
}
