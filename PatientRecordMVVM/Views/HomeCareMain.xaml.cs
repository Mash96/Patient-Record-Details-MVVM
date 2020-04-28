using System.Windows;
using PatientRecordMVVM.ViewModels;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.Views
{
    /// <summary>
    /// Interaction logic for HomeCareMain.xaml
    /// </summary>
    public partial class HomeCareMain : Window
    {
        public HomeCareMain()
        {
            InitializeComponent();         
            AddPatient.Visibility = Visibility.Hidden;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
    }
}
