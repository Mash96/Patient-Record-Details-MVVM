using System;
using System.Windows;
using PatientRecordMVVM.Views;
using PatientRecordMVVM.ViewModels;

namespace PatientRecordMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(Object sender, StartupEventArgs e)
        {
            PatientRecordDetails userWindow = new PatientRecordDetails();
            userWindow.Title = "Patient Record Details";
            PatientRecordDetailsViewModel patientRecordDetailsViewModel = new PatientRecordDetailsViewModel();
            userWindow.DataContext = patientRecordDetailsViewModel;
            userWindow.Show();
        }
    }
}
