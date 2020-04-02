using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace PatientRecordMVVM.Model
{
    public class PatientRecordDetailsModel
    {
        private DateTime m_dob = DateTime.Today;
        private PatientAddress m_address = new PatientAddress();
        private BitmapImage m_imgSource;
        public string Name { get; set; }

        public PatientAddress Address { 
            get
            {
                return m_address;
            }
            set
            {
                m_address = value;
            }
        }

        public string Gender { get; set; }

        public DateTime Dob
        {
            get
            {
                return m_dob;
            }
            set
            {
                m_dob = value;

            }
        }
        
        public int Age { get; set; }

        public BitmapImage Image { 
            get
            {
                return m_imgSource;
            }
            set
            {
                m_imgSource = value;
            }
        }
        public string Dept { get; set; }
        public string Ward { get; set; }
        public string DocInCharge { get; set; }

    }




}
