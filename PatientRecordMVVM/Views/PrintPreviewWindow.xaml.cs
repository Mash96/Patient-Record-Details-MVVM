using PatientRecordMVVM.Model;
using PatientRecordMVVM.ViewModels;
using System.Windows;

namespace PatientRecordMVVM.Views
{
    /// <summary>
    /// Interaction logic for PrintPreviewWindow.xaml
    /// </summary>
    public partial class PrintPreviewWindow : Window
    {
        public PrintPreviewWindow(PatientRecordDetailsModel patient)
        {
            InitializeComponent();
            PrintPreviewViewModel printPreviewViewModel = new PrintPreviewViewModel(patient);
            PrintPreview.DataContext = printPreviewViewModel;
        }
    }
}
