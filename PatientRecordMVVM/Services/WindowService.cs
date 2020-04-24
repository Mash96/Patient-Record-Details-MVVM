using PatientRecordMVVM.Views;
using PatientRecordMVVM.Model;
using PatientRecordMVVM.ViewModels;
using System.Windows;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {
        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreviewControl printPreview = new PrintPreviewControl();
            printPreview.DataContext = new PrintPreviewViewModel(patient);
            printPreview.Visibility = Visibility.Visible;
        }
    }
}
