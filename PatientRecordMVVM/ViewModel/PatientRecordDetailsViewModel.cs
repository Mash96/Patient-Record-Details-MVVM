using System;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PatientRecordMVVM.Model;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using PatientRecordMVVM.Services;
using PatientRecordMVVM.Commands;

namespace PatientRecordMVVM.ViewModel
{
    class PatientRecordDetailsViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Data Members
        private IWindowService m_windowNavigationService;
        #endregion

        #region Fields
        private string m_patientId;
        private string m_patientName;
        private string m_patientGender;
        private int m_patientAge;
        private DateTime m_patientDateofbirth = DateTime.Today;
        private ImageSource m_patientImageSource;
        private PatientAddress m_patientAddress;
        private string m_patientDepartment;
        private string m_patientWard;
        private string m_patientDocInCharge;
        #endregion

        #region Constructors
        public PatientRecordDetailsViewModel()
        {

            this.Department = new ObservableCollection<string>
            {
                 "Orthopedic", "Cardiology", "Oncology", "Obstetrics and Gynaecology", "Cardiovascular ICU"
            };

            this.Ward = new ObservableCollection<string>
            {
                "Cardiology Ward", "Neurology Ward", "Obstetrics and Gynaecology Ward", "Oncology Ward", "Maternity Ward"
            };           

            this.DocInCharge = new ObservableCollection<string> 
            {
                "Dr. Asala Perera", "Dr. Janaka Thisera", "Dr. Manik Perera", "Dr. Seetha Fonseka", "Dr. Athula Dissanayake"
            };

            m_windowNavigationService = new WindowService();

            Patient = new PatientRecordDetailsModel();

            // Has an issue
            PatientAddress = new PatientAddress();
        }
        #endregion

        #region Properties
        public PatientRecordDetailsModel Patient { get; set; }

        public ObservableCollection<String> Department { get; set; }

        public ObservableCollection<String> Ward { get; set; }

        public ObservableCollection<String> DocInCharge { get; set; }

        public string PatientID
        {
            get => m_patientId;
            set
            {
                m_patientId = value;
                OnPropertyChange("PatientID");
            }
        }

        public string PatientName
        {
            get => m_patientName;
            set
            {
                m_patientName = value;
                OnPropertyChange("PatientName");
            }
        }

        //#issue
        public PatientAddress PatientAddress
        {
            get => m_patientAddress;
            set
            {
                m_patientAddress = value;
                OnPropertyChange("PatientAddress");
            }
        }

        public string PatientGender
        {
            get => m_patientGender;
            set
            {
                m_patientGender = value;
                OnPropertyChange("PatientGender");
            }
        }

        public DateTime PatientDateOfBirth
        {
            get => m_patientDateofbirth;
            set
            {
                m_patientDateofbirth = value;
                OnPropertyChange("PatientDateOfBirth");
            }
        }

        public int PatientAge
        {
            get => m_patientAge;
            set
            {
                m_patientAge = value;
                OnPropertyChange("PatientAge");
            }
        }

        public ImageSource PatientImageSource
        {
            get => m_patientImageSource;
            set
            {
                m_patientImageSource = value;
                OnPropertyChange("PatientImageSource");
            }
        }

        public string PatientDepartment
        {
            get => m_patientDepartment;
            set
            {
                m_patientDepartment = value;
                OnPropertyChange("PatientDepartment");
            }
        }

        public string PatientWard
        {
            get => m_patientWard;
            set
            {
                m_patientWard = value;
                OnPropertyChange("PatientWard");
            }
        }

        public string PatientDotorcInCharge
        {
            get => m_patientDocInCharge;
            set
            {
                m_patientDocInCharge = value;
                OnPropertyChange("PatientDotorcInCharge");
            }
        }
        #endregion

        #region <PatientRecordDetails> Members
        public string CurrentDate => m_windowNavigationService.GetCurrentDate();

        public string GuidGenerator => GetGuid();
        #endregion

        #region Properties : Commands
        public ICommand PreviewCommand
        {
            get => new PatientRecordDetailsCommands(param => this.OnPreviewCommandExecute(), param => OnPreviewCommandCanExecute());
        }

        public ICommand GetPatientGenderCommand
        {
            get => new PatientRecordDetailsCommands(OnGetPatientGenderCommandExecute, OnGetPatientGenderCommandCanExecute);
        }

        public ICommand GetPatientImageCommand
        {
            get => new PatientRecordDetailsCommands(param => OnGetPatientImageCommandExecute(), param => OnGetPatientImageCommandCanExecute());
        }

        public ICommand ClearPatientCommand
        {
            get => new PatientRecordDetailsCommands(param => OnClearPatientCommandExecute(), param => OnClearPatientCommandCanExecute());
        }
        #endregion


        #region Handlers : Members       
        private string GetGuid()
        {
            Guid guid = Guid.NewGuid();

            string guidString = guid.ToString();
            PatientID = guidString;

            return PatientID;
        }

        private PatientRecordDetailsModel PopulatePatientDetails()
        {
            Patient.PatientId = PatientID;
            Patient.PatientName = PatientName;
            Patient.PatientAddress = PatientAddress;
            Patient.PatientGender = PatientGender;
            Patient.PatientDateOfBirth = PatientDateOfBirth;
            Patient.PatientAge = PatientAge;
            Patient.PatientImageSource = PatientImageSource;
            Patient.PatientDepartment = PatientDepartment;
            Patient.PatientWard = PatientWard;
            Patient.PatientDoctorInCharge = PatientDotorcInCharge;

            return Patient;
        }
        #endregion

        #region Handlers : Commands
        private void OnPreviewCommandExecute()
        {
            PatientRecordDetailsModel getPatientDetails = PopulatePatientDetails();
            m_windowNavigationService.CreateWindow(getPatientDetails);
        }

        private bool OnPreviewCommandCanExecute()
        {
            return PatientName != null;
        }

        private bool OnGetPatientGenderCommandCanExecute(object parameter)
        {
            return parameter != null;
        }

        private void OnGetPatientGenderCommandExecute(object parameter)
        {
            PatientGender = (string)parameter;
        }

        private bool OnClearPatientCommandCanExecute()
        {
            return PatientName != null || PatientAddress != null || PatientGender != null || PatientAge != 0;
        }

        private void OnClearPatientCommandExecute()
        {
            PatientName = null;
            PatientAddress = new PatientAddress();
            PatientGender = null;
            PatientDateOfBirth = DateTime.Today;
            PatientAge = 0;
            PatientImageSource = null;
            PatientDepartment = null;
            PatientWard = null;
            PatientDotorcInCharge = null;
        }

        private bool OnGetPatientImageCommandCanExecute() => true;

        private void OnGetPatientImageCommandExecute()
        {

            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Maneesha\Desktop\Dips Y-knots\images\",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                            "All files (*.*)|*.*"
            };
            if (dlg.ShowDialog() == true)
            {
                String m_fileName = dlg.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(m_fileName));
                PatientImageSource = bitmap;
                
            }
        }
        #endregion

        #region Event Handlers
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
