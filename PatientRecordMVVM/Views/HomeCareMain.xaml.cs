using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using PatientRecordMVVM.ViewModels;

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
            this.DataContext = new HomeCareMainViewModel();
            PatientRecordDetailsViewModel patientRecordDetailsViewModel = new PatientRecordDetailsViewModel();           
            AddPatient.DataContext = patientRecordDetailsViewModel;
            AddPatient.Visibility = Visibility.Hidden;

            //PrintPreviewViewModel printPreviewViewModel -new PrintPreviewViewModel(patient);
            //PrintPreview.Visibility = Visibility.Hidden;
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
