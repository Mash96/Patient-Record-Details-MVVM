using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;

namespace PatientRecordMVVM.Model
{
    public class PatientRecordDetailsModel : INotifyPropertyChanged
    {
        private string m_name;
        private string m_gender;
        private int m_age;
        private DateTime m_dob = DateTime.Today;
        private ImageSource m_imageSource;
        private PatientAddress m_address = new PatientAddress();
        private string m_dept;
        private string m_ward;
        private string m_docInCharge;

        public string Name {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                OnPropertyChange("Name");
            }
        }
        public PatientAddress Address { 
            get
            {
                return m_address;
            }
            set
            {
                m_address = value;
                OnPropertyChange("Address");
            }
        }
        public string Gender {
            get
            {
                return m_gender;
            }
            set
            {
                m_gender = value;
                OnPropertyChange("Gender");
            }
        }
        public DateTime Dob
        {
            get
            {
                return m_dob;
            }
            set
            {
                m_dob = value;
                OnPropertyChange("Dob");

            }
        }       
        public int Age {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
                OnPropertyChange("Age");
            }
        }
        public ImageSource ImageView {
            get
            {
                return m_imageSource;
            }
            set
            {
                m_imageSource = value;
                OnPropertyChange("ImageView");
            }
        }      
        public string Dept {
            get
            {
                return m_dept;
            }
            set
            {
                m_dept = value;
                OnPropertyChange("Dept");
            }
        }
        public string Ward {
            get
            {
                return m_ward;
            }
            set
            {
                m_ward = value;
                OnPropertyChange("Ward");
            }
        }
        public string DocInCharge {
            get
            {
                return m_docInCharge;
            }
            set
            {
                m_docInCharge = value;
                OnPropertyChange("DocInCharge");
            }
        }

        // INotify     
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
