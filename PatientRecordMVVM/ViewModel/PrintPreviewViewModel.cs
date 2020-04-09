using System.Windows.Media;
using PatientRecordMVVM.Model;
using PatientRecordMVVM.Services;

namespace PatientRecordMVVM.ViewModel
{
    class PrintPreviewViewModel
    {
        #region Data Members
        private IWindowService m_windowService;
        #endregion

        #region Constructors
        public PrintPreviewViewModel(PatientRecordDetailsModel patient)
        {
            string id = patient.PatientId;

            PatientID = id.PadRight(6).Substring(0,6);
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

        #region <PrintPreview> Members
        public string CurrentDate => m_windowService.GetCurrentDate();
        #endregion

        
    }
}
