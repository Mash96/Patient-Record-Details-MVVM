using System.Windows;
using System.Windows.Controls;
using PatientRecordMVVM.Utilities;

namespace PatientRecordMVVM.Controls
{
    /// <summary>
    /// Interaction logic for MainHeaderControl.xaml
    /// </summary>
    public partial class MainHeaderControl : UserControl
    {
        public MainHeaderControl()
        {
            InitializeComponent();
            English.IsChecked = true;
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            English.IsChecked = true;
            if (Norwegian.IsChecked == true)
            {
                Norwegian.IsChecked = false;
            }

            LanguageTransalationUtility.TransalationUtility.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        }

        private void Norwegian_Click(object sender, RoutedEventArgs e)
        {
            
            Norwegian.IsChecked = true;
            if (English.IsChecked == true)
            {
                English.IsChecked = false;
            }

            LanguageTransalationUtility.TransalationUtility.CurrentCulture = new System.Globalization.CultureInfo("nb-NO");
        }
    }
}
