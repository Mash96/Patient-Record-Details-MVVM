using System.Windows;

namespace PatientRecordMVVM.Views
{
    /// <summary>
    /// Interaction logic for HomeCareMain.xaml
    /// </summary>
    public partial class HomeCareMainWindow : Window
    {
        public HomeCareMainWindow()
        {
            InitializeComponent();
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
