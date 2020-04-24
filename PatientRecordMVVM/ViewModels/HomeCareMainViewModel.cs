using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using PatientRecordMVVM.Commands;
using PatientRecordMVVM.Services;

namespace PatientRecordMVVM.ViewModels
{
    class HomeCareMainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Fields
        #endregion

        #region Constructors
        public HomeCareMainViewModel()
        {
           
        }
        #endregion

        #region Properties
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
