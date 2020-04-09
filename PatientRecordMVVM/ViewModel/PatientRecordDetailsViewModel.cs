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
        IWindowService windowNav;
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

        // Constructor
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

            windowNav = new WindowNavService();

            Patient = new PatientRecordDetailsModel();

            PatientAddress = new PatientAddress();
        }

        public PatientRecordDetailsModel Patient { get; set; }
        public ObservableCollection<String> Department { get; set; }
        public ObservableCollection<String> Ward { get; set; }
        public ObservableCollection<String> DocInCharge { get; set; }

        public string PatientID
        {
            get
            {
                return m_patientId;
            }
            set
            {
                m_patientId = value;
                OnPropertyChange("PatientID");
            }
        }

        public string PatientName
        {
            get
            {
                return m_patientName;
            }
            set
            {
                m_patientName = value;
                OnPropertyChange("PatientName");
            }
        }

        //#issue
        public PatientAddress PatientAddress
        {
            get
            {
                return m_patientAddress;
            }
            set
            {
                m_patientAddress = value;
                OnPropertyChange("PatientAddress");
            }
        }

        public string PatientGender
        {
            get
            {
                return m_patientGender;
            }
            set
            {
                m_patientGender = value;
                OnPropertyChange("PatientGender");
            }
        }

        public DateTime PatientDateOfBirth
        {
            get
            {
                return m_patientDateofbirth;
            }
            set
            {
                m_patientDateofbirth = value;
                OnPropertyChange("PatientDateOfBirth");
            }
        }

        public int PatientAge
        {
            get
            {
                return m_patientAge;
            }
            set
            {
                m_patientAge = value;
                OnPropertyChange("PatientAge");
            }
        }

        public ImageSource PatientImageSource
        {
            get
            {
                return m_patientImageSource;
            }
            set
            {
                m_patientImageSource = value;
                OnPropertyChange("PatientImageSource");
            }
        }

        public string PatientDepartment
        {
            get
            {
                return m_patientDepartment;
            }
            set
            {
                m_patientDepartment = value;
                OnPropertyChange("PatientDepartment");
            }
        }

        public string PatientWard
        {
            get
            {
                return m_patientWard;
            }
            set
            {
                m_patientWard = value;
                OnPropertyChange("PatientWard");
            }
        }

        public string PatientDotorcInCharge
        {
            get
            {
                return m_patientDocInCharge;
            }
            set
            {
                m_patientDocInCharge = value;
                OnPropertyChange("PatientDotorcInCharge");
            }
        }
        
        public string CurrentDate
        {
            get
            {
                String date;
                String time;
                String Date_Time;

                DateTime dateTime = DateTime.Now;
                date = dateTime.ToString("d");
                time = dateTime.ToString("T");
                Date_Time = date + " " + time;
                return Date_Time;
            }          
        }

        public string GuidGenerator
        {
            get
            {
                Guid guid = Guid.NewGuid();
                string guidString = guid.ToString();
                PatientID = guidString;
                return PatientID;
            }
        }

        // Commands
        // Submit command
        public ICommand SubmitCommand
        {
            get => new PatientRecordDetailsCommands(param => this.PrintPreview(), param => CanPrintPreview());
        }

        // Radio Buttons command
        public ICommand RadioCommand
        {
            get => new PatientRecordDetailsCommands(GetRadioContent, CanRadioContent);
        }

        // Image Browser command
        public ICommand ImageCommand
        {
            get => new PatientRecordDetailsCommands(param => GetImage(), param => CanImage());
        }

        // Clear Command
        public ICommand ClearCommand
        {
            get => new PatientRecordDetailsCommands(param => Clear(), param => CanClear());
        }

        // Implimentation
        private void PrintPreview()
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

            windowNav.CreateWindow(Patient);           
        }

        private bool CanPrintPreview()
        {
            if (PatientName != null )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CanRadioContent(object parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else return false;
        }

        private void GetRadioContent(object parameter)
        {
            PatientGender = (string)parameter;
        }

        private bool CanClear()
        {
            if(PatientName != null || PatientAddress != null || PatientGender != null || PatientAge != 0)
            {
                return true;
            }
            else return false;
        }

        private void Clear()
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

        private bool CanImage()
        {
            return true;
        }

        private void GetImage()
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\Users\Maneesha\Desktop\Dips Y-knots\images\";
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                            "All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                String m_fileName = dlg.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(m_fileName));
                PatientImageSource = bitmap;
                
            }
        }

        // INotify     
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
