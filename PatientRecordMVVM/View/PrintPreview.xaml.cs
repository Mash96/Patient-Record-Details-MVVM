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
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.View
{
    /// <summary>
    /// Interaction logic for PrintPreview.xaml
    /// </summary>
    public partial class PrintPreview : Window
    {
        private PrintPreviewViewModel vm;
        private PatientRecordDetailsModel patient;

        public PrintPreview()
        {
            InitializeComponent();
            //this.DataContext = new PrintPreviewViewModel(patient);
            //vm = new PrintPreviewViewModel(patient);
            //this.DataContext = vm;
        }

    }
}
