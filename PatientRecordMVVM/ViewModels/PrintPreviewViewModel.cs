using System.Windows.Media;
using PatientRecordMVVM.Model;
using PatientRecordMVVM.Services;
using PatientRecordMVVM.Commands;
using System.Windows.Input;
using System.Windows.Controls;
using PatientRecordMVVM.Utilities;
using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.ViewModel
{
    class PrintPreviewViewModel
    {
        #region Fields
        private IWindowService m_windowService;
        private PatientRecordDetailsModel patient;
        #endregion

        #region Constructors
        public PrintPreviewViewModel(PatientRecordDetailsModel patient)
        {
            this.patient = patient;
            string id = patient.PatientId;

            PatientID = id.PadRight(6).Substring(0, 6);
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

            m_windowService = new WindowService();
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
        public ICommand DefaultPrintCommand => new PatientRecordDetailsCommands(param => OnDefaultPrintCommandExecute(), param => OnDefaultPrintCommandCanExecute());

        public ICommand ConfigureAndPrintCommand => new PatientRecordDetailsCommands(param => OnConfigureAndPrintCommandExecute(), param => OnConfigureAndPrintCommandCanExecute());
        #endregion

        #region Handlers : Commands
        private void OnDefaultPrintCommandExecute()
        {
            PrintUtility.DefaultPrintPatientDetails(patient);
        }

        private bool OnDefaultPrintCommandCanExecute()
        {
            return true;
        }

        private void OnConfigureAndPrintCommandExecute()
        {
            PrintUtility.ConfigureAndPrintPatientDetails(patient);
        }

        private bool OnConfigureAndPrintCommandCanExecute()
        {
            return true;
        }
        #endregion
    }
}