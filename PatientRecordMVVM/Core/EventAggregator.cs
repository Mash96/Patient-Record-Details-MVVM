using System;
using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.Core
{
    public class EventAggregator : EventArgs
    {
        private PatientRecordDetailsModel m_patientObject;

        public EventAggregator(PatientRecordDetailsModel patient)
        {
            this.m_patientObject = patient;
        }

        public PatientRecordDetailsModel PatientData {
            get { return m_patientObject; }
            set
            {
                m_patientObject = value;
            }
        }
    }
}
