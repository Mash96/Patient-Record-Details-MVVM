using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PatientRecordMVVM.ViewModel;

namespace PatientRecordMVVM.View
{
    /// <summary>
    /// Interaction logic for PatientRecordDetails.xaml
    /// </summary>
    public partial class PatientRecordDetails : Window
    {
        private PatientRecordDetailsViewModel patientRecordDetailsViewModel;

        public PatientRecordDetails()
        {
            InitializeComponent();
            patientRecordDetailsViewModel = new PatientRecordDetailsViewModel();
            this.DataContext = patientRecordDetailsViewModel;
            //Date.SelectedDate = DateTime.Today;
        }
    }
}
