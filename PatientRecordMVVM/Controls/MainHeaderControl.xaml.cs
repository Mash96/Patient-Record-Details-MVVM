using PatientRecordMVVM.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

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
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            English.IsChecked = true;
            if (Norwegian.IsChecked == true)
            {
                Norwegian.IsChecked = false;
            }
            

        }

        private void Norwegian_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ng-NO");
            Norwegian.IsChecked = true;
            if (English.IsChecked == true)
            {
                English.IsChecked = false;
            }
            
            HomeCareMainWindow homeCareMain = new HomeCareMainWindow();
            homeCareMain.Show();
        }
    }
}
