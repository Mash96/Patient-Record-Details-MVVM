using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using PatientRecordMVVM.Commands;
using PatientRecordMVVM.Model;

namespace PatientRecordMVVM.ViewModels
{
    class HomeCareMainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Fields
        private PatientRecordDetailsViewModel m_patientRecordDetailsViewModel;
        #endregion

        #region Constructors
        public HomeCareMainViewModel()
        {
            m_patientRecordDetailsViewModel = new PatientRecordDetailsViewModel();
        }
        #endregion

        #region Properties
        public PatientRecordDetailsViewModel PatientRecordDetailsViewModel
        {
            get => m_patientRecordDetailsViewModel;
            set
            {
                m_patientRecordDetailsViewModel = value;
                OnPropertyChange("PatientRecordDetailsViewModel");
            }
        }
        #endregion

        #region Commands
        public ICommand LogoutCommand => new PatientRecordDetailsCommands(param => OnLogoutCommandExecute(), param => OnLogoutCommandCanExecute());

        public ICommand AddPatientCommand => new PatientRecordDetailsCommands(OnPatientRecordDetailsCommandsExecute, OnPatientRecordDetailsCommandsCanExecute);
        #endregion

        #region Handlers: Commands
        private void OnLogoutCommandExecute()
        {
            // MVVM Violation
            Application.Current.Shutdown();
        }

        private bool OnLogoutCommandCanExecute()
        {
            return true;
        }

        private void OnPatientRecordDetailsCommandsExecute(object parameter)
        {
            FrameworkElement frameworkElement = (Visual)parameter as FrameworkElement;
            if (frameworkElement.Visibility == Visibility.Hidden)
            {
                frameworkElement.Visibility = Visibility.Visible;
            }
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
