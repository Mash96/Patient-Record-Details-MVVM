using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace PatientRecordMVVM.Model
{
    public class PatientRecordDetailsModel
    {
        private DateTime dob = DateTime.Today;
        private PatientAddress address = new PatientAddress();
        private BitmapImage imgSource;
        public string Name { get; set; }

        public PatientAddress Address { 
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Gender { get; set; }

        public DateTime Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;

            }
        }
        
        public int Age { get; set; }

        public BitmapImage Image { 
            get
            {
                return imgSource;
            }
            set
            {
                imgSource = value;
            }
        }
        public string Dept { get; set; }
        public string Ward { get; set; }
        public string DocInCharge { get; set; }

    }




}
