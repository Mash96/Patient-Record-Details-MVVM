using PatientRecordMVVM.Views;
using PatientRecordMVVM.ViewModel;
using PatientRecordMVVM.Model;
using System.Windows;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {
        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);
            printPreview.ShowDialog();
        }
    }
}
