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
using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.ViewModels
{
    class PatientRecordDetailsViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Fields
        private IWindowService m_windowService;
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
            Department = new ObservableCollection<string>
            {
                 "Orthopedic", "Cardiology", "Oncology", "Obstetrics and Gynaecology", "Cardiovascular ICU"
            };

            Ward = new ObservableCollection<string>
            {
                "Cardiology Ward", "Neurology Ward", "Obstetrics and Gynaecology Ward", "Oncology Ward", "Maternity Ward"
            };

            DocInCharge = new ObservableCollection<string>
            {
                "Dr. Asala Perera", "Dr. Janaka Thisera", "Dr. Manik Perera", "Dr. Seetha Fonseka", "Dr. Athula Dissanayake"
            };

            m_windowService = new WindowService();

            Patient = new PatientRecordDetailsModel();

            PatientAddress = new PatientAddress();
        }
        #endregion

        #region Properties
        public PatientRecordDetailsModel Patient { get; set; }

        public ObservableCollection<string> Department { get; set; }

        public ObservableCollection<string> Ward { get; set; }

        public ObservableCollection<string> DocInCharge { get; set; }

        public string PatientName
        {
            get => m_patientName;
            set
            {
                m_patientName = value;
                OnPropertyChange("PatientName");
            }
        }

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

        public string CurrentDate => GetCurrentDate();

        public string GuidGenerator => GetGuid();
        #endregion

        #region Properties : Commands
        public ICommand PreviewCommand
        {
            get => new PatientRecordDetailsCommands(param => OnPreviewCommandExecute(), param => OnPreviewCommandCanExecute());
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
            Patient.PatientId = guidString;

            return Patient.PatientId;
        }

        private string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;

            string date = dateTime.ToString("d");
            string time = dateTime.ToString("T");
            string Date_Time = date + " " + time;
            Patient.PatientRegisteredDate = Date_Time;

            return Patient.PatientRegisteredDate;
        }

        private PatientRecordDetailsModel PopulatePatientDetails()
        {
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
            m_windowService.CreateWindow(getPatientDetails);
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Maneesha\Desktop\Dips Y-knots\images\",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                            "All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                string m_fileName = openFileDialog.FileName;
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
