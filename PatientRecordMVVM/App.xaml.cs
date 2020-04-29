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
            HomeCareMain homeCareMain = new HomeCareMain();
            homeCareMain.Title = "Home Care";
            //HomeCareMainViewModel homeCareMainViewModel = new HomeCareMainViewModel();
            //homeCareMain.DataContext = homeCareMainViewModel;
            homeCareMain.Show();

            //PatientRecordDetails userWindow = new PatientRecordDetails();
            //userWindow.Title = "Patient Record Details";
            //PatientRecordDetailsViewModel patientRecordDetailsViewModel = new PatientRecordDetailsViewModel();
            //userWindow.DataContext = patientRecordDetailsViewModel;
            //userWindow.Show();
        }
    }
}
