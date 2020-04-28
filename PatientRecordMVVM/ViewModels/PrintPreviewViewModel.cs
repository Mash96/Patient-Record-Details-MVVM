using System.Windows.Media;
using PatientRecordMVVM.Model;
using PatientRecordMVVM.Services;
using PatientRecordMVVM.Commands;
using System.Windows.Input;
using System.Windows.Controls;
using PatientRecordMVVM.Utilities;
using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.ViewModels
{
    class PrintPreviewViewModel
    {

        #region Constructors
        public PrintPreviewViewModel(PatientRecordDetailsModel patient)
        {            
            PatientID = patient.PatientId;
            PatientRegisteredDate = patient.PatientRegisteredDate;
            PatientName = patient.PatientName;
            PatientAddress = patient.PatientAddress;
            PatientGender = patient.PatientGender;
            PatientDateOfBirth = patient.PatientDateOfBirth.ToShortDateString();
            PatientAge = patient.PatientAge;
            PatientImageSource = patient.PatientImageSource;
            PatientDepartment = patient.PatientDepartment;
            PatientWard = patient.PatientWard;
            PatientDotorcInCharge = patient.PatientDoctorInCharge;
        }
        #endregion

        #region Properties
        public string PatientID { get; set; }

        public string PatientRegisteredDate { get; set; }

        public string PatientName { get; set; }

        public PatientAddress PatientAddress { get; set; }

        public string PatientGender { get; set; }

        public string PatientDateOfBirth { get; set; }

        public int PatientAge { get; set; }

        public ImageSource PatientImageSource { get; set; }

        public string PatientDepartment { get; set; }

        public string PatientWard { get; set; }

        public string PatientDotorcInCharge { get; set; }
        #endregion

        #region Properties : Commands
        public ICommand DefaultPrintCommand => new PatientRecordDetailsCommands(OnDefaultPrintCommandExecute, OnDefaultPrintCommandCanExecute);

        public ICommand ConfigureAndPrintCommand => new PatientRecordDetailsCommands(OnConfigureAndPrintCommandExecute, OnConfigureAndPrintCommandCanExecute);
        #endregion

        #region Handlers : Commands
        private void OnDefaultPrintCommandExecute(object parameter)
        {
            PrintDialog printDialog = PrintUtility.DefaultPrintAdjustments();
            printDialog.PrintVisual((Visual)parameter, "Print");
        }

        private bool OnDefaultPrintCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnConfigureAndPrintCommandExecute(object parameter)
        {
            PrintDialog printDialog = PrintUtility.ConfigureAndPrintAdjustments();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual((Visual)parameter, "Print");
            }

        }

        private bool OnConfigureAndPrintCommandCanExecute(object parameter)
        {
            return true;
        }
        #endregion
    }
}