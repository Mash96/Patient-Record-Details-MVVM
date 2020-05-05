using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using PatientRecordMVVM.Commands;
using PatientRecordMVVM.Models;

namespace PatientRecordMVVM.ViewModels
{
    class HomeCareMainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Fields
        private object m_selectedViewModel;
        private Visibility m_visibilityControl = Visibility.Collapsed;
        #endregion

        #region Constructors
        public HomeCareMainViewModel()
        {
            
        }
        #endregion

        #region Properties
        public object SelectedViewModel
        {
            get => m_selectedViewModel;
            set
            {
                m_selectedViewModel = value;
                OnPropertyChange("SelectedViewModel");
            }
        }

        //public PrintPreviewViewModel PrintPreviewViewModel
        //{
        //    get;set;
        //}

        //public static void GetPatientObject(PatientRecordDetailsModel patient)
        //{
           
        //}


        //public Visibility VisibilityControl
        //{
        //    get
        //    {
        //        return m_visibilityControl;
        //    }
        //    set
        //    {
        //        m_visibilityControl = value;
        //        OnPropertyChange("VisibilityControl");
        //    }
        //}
        #endregion

        #region Commands
        public ICommand LogoutCommand => new PatientRecordDetailsCommands(param => OnLogoutCommandExecute(), param => OnLogoutCommandCanExecute());

        public ICommand AddPatientCommand => new PatientRecordDetailsCommands(OnPatientRecordDetailsCommandsExecute, OnPatientRecordDetailsCommandsCanExecute);
        #endregion

        #region Handlers: Commands
        private void OnLogoutCommandExecute()
        {            
            //Application.Current.Shutdown();
        }

        private bool OnLogoutCommandCanExecute()
        {
            return true;
        }

        private void OnPatientRecordDetailsCommandsExecute(object parameter)
        {
            SelectedViewModel = new PatientRecordDetailsViewModel();
        }

        private bool OnPatientRecordDetailsCommandsCanExecute(object parameter)
        {
            return true;
        }
        #endregion

        #region Event Handlers
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
