using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PatientRecordMVVM.View;
using PatientRecordMVVM.ViewModel;

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
