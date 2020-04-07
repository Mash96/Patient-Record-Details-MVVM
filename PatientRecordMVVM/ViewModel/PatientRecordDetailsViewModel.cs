using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PatientRecordMVVM.Model;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using PatientRecordMVVM.Services;

namespace PatientRecordMVVM.ViewModel
{
    class PatientRecordDetailsViewModel
    {
        WindowNavService windowNav = new WindowNavService();

        // Constructor
        public PatientRecordDetailsViewModel()
        {

            this.Department = new ObservableCollection<string>();
            this.Department.Add("Orthopedic");
            this.Department.Add("Cardiology");
            this.Department.Add("Oncology");
            this.Department.Add("Obstetrics and Gynaecology");
            this.Department.Add("Cardiovascular ICU");

            this.Ward = new ObservableCollection<string>();
            this.Ward.Add("Cardiology Ward");
            this.Ward.Add("Neurology Ward");
            this.Ward.Add("Obstetrics and Gynaecology Ward");
            this.Ward.Add("Oncology Ward");
            this.Ward.Add("Maternity Ward");

            this.DocInCharge = new ObservableCollection<string>();
            this.DocInCharge.Add("Dr. Asala Perera");
            this.DocInCharge.Add("Dr. Janaka Thisera");
            this.DocInCharge.Add("Dr. Manik Perera");
            this.DocInCharge.Add("Dr. Seetha Fonseka");
            this.DocInCharge.Add("Dr. Athula Dissanayake");

            Patient = new PatientRecordDetailsModel();
        }

        public PatientRecordDetailsModel Patient { get; set; }
        public ObservableCollection<String> Department { get;set; }
        public ObservableCollection<String> Ward { get; set; }
        public ObservableCollection<String> DocInCharge { get; set; }

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

        // Commands
        // Submit command
        public ICommand SubmitCommand
        {
            get => new PatientRecordDetailsCommand(param => this.Submit(), param => CanSubmit());
        }

        // Radio Buttons command
        public ICommand RadioCommand
        {
            get => new PatientRecordDetailsCommand(getRadioContent, canRadioContent);
        }

        // Image Browser command
        public ICommand ImageCommand
        {
            get => new PatientRecordDetailsCommand(param => getImage(), param => canImage());
        }

        // Clear Command
        public ICommand ClearCommand
        {
            get => new PatientRecordDetailsCommand(param => Clear(), param => CanClear());
        }

        // Implimentation
        private void Submit()
        {

            IWindowService windowService = windowNav;
            windowService.CreateWindow(Patient);
            
        }

        private bool CanSubmit()
        {
            return true;
        }

        private bool canRadioContent(object parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else return false;
        }

        private void getRadioContent(object parameter)
        {
            Patient.Gender = (string)parameter;
        }


        private bool canImage()
        {
            return true;
        }

        private void Clear()
        {
            Patient.Name = null;
            Patient.Address = null;
            Patient.Gender = null;
            Patient.Dob = DateTime.Now;
            Patient.Age = 0;
            Patient.ImageView = null;
            Patient.Dept = null;
            Patient.Ward = null;
            Patient.DocInCharge = null;
            
        }

        private bool CanClear()
        {
            return true;
        }

        private void getImage()
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\Users\Maneesha\Desktop\Dips Y-knots\images\";
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                            "All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                String m_fileName = dlg.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(m_fileName));
                Patient.ImageView = bitmap;
                
            }
        }
    }
}
