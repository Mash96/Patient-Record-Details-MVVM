using System.Windows;
using System.Windows.Controls;

namespace PatientRecordMVVM.Views
{
    /// <summary>
    /// Interaction logic for AddPatientRecordDetails.xaml
    /// </summary>
    public partial class AddPatientRecordDetails : UserControl
    {
        public AddPatientRecordDetails()
        {
            InitializeComponent();
        }

        private void ButtonCancel(object sender, RoutedEventArgs e)
        {
            AddPatientForm.Visibility = Visibility.Collapsed;
        }
    }
}
