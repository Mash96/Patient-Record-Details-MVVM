﻿using System;
using System.Windows.Media;

namespace PatientRecordMVVM.Model
{
    public class PatientRecordDetailsModel
    {
        public string PatientId { get; set; }

        public string PatientName { get; set; }

        // isuues
        public PatientAddress PatientAddress { get; set; }

        public string PatientGender { get; set; }

        public DateTime PatientDateOfBirth { get; set; }

        public int PatientAge { get; set; }

        public ImageSource PatientImageSource { get; set; }

        public string PatientDepartment { get; set; }

        public string PatientWard { get; set; }

        public string PatientDoctorInCharge { get; set; }
    }
}