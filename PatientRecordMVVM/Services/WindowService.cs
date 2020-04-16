using PatientRecordMVVM.Views;
using PatientRecordMVVM.ViewModel;
using PatientRecordMVVM.Model;
using System;
using System.Windows.Controls;
using System.Printing;
using System.Windows;
using System.Windows.Media;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {

        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);
            printPreview.Show();
        }
    }
}
