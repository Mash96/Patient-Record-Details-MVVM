using System;
using System.Collections.Generic;
using System.Text;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.ViewModel
{
    class PrintPreviewViewModel
    {
       
        public PrintPreviewViewModel(PatientRecordDetailsModel patient)
        {
            Patient = patient;
           
        }

        public PatientRecordDetailsModel Patient{get; set;}

        public String DateOfBirth
        {
            get
            {
                var datetime = Patient.Dob.ToShortDateString();
                return datetime;
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
