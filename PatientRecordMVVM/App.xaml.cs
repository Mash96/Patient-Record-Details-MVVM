using System;
using System.Windows;
using PatientRecordMVVM.Views;

namespace PatientRecordMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(Object sender, StartupEventArgs e)
        {
            HomeCareMainWindow homeCareMain = new HomeCareMainWindow();
            homeCareMain.Title = "Home Care";
            homeCareMain.Show();
        }
    }
}
