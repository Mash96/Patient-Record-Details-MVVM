using PatientRecordMVVM.View;
using PatientRecordMVVM.ViewModel;
using PatientRecordMVVM.Model;
using System;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {
        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview
            {
                DataContext = new PrintPreviewViewModel(patient)
            };

            printPreview.Show();
        }

        public string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;

            string date = dateTime.ToString("d");
            string time = dateTime.ToString("T");
            string Date_Time = date + " " + time;

            return Date_Time;
        }
    }
}
