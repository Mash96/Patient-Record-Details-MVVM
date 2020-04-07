using System;
using System.Collections.Generic;
using System.Text;
using PatientRecordMVVM.View;
using PatientRecordMVVM.ViewModel;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.Services
{
    class WindowNavService : IWindowService
    {
        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview
            {
                DataContext = new PrintPreviewViewModel(patient)
            };
            printPreview.Show();

        }
    }
}
