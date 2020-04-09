using System;
using System.Windows.Media;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.ViewModel
{
    class PrintPreviewViewModel
    {
        private string m_patientId;
        private string m_patientName;
        private string m_patientGender;
        private int m_patientAge;
        private string m_patientDateofbirth;
        private ImageSource m_patientImageSource;
        private PatientAddress m_patientAddress = new PatientAddress();
        private string m_patientDepartment;
        private string m_patientWard;
        private string m_patientDocInCharge;

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
        }

        public string PatientID
        {
            get
            {
                return m_patientId;
            }
            set
            {
                m_patientId = value;
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
            }
        }

        public PatientAddress PatientAddress
        {
            get
            {
                return m_patientAddress;
            }
            set
            {
                m_patientAddress = value;
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
            }
        }

        public string PatientDateOfBirth
        {
            get
            {
                return m_patientDateofbirth;
            }
            set
            {
                m_patientDateofbirth = value;
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
    }
}
