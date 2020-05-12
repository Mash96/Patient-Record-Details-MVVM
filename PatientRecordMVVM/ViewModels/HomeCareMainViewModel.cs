using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
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
        private object m_selectedViewModel;
        private IWindowService m_windowService;
        #endregion

        #region Constructors
        public HomeCareMainViewModel()
        {
            m_windowService = new WindowService();           
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

    public string LangSwitch { get; private set; } = null;

        #endregion

        #region Commands
        public ICommand AddPatientCommand => new PatientRecordDetailsCommands(OnPatientRecordDetailsCommandsExecute, OnPatientRecordDetailsCommandsCanExecute);

        public ICommand ChangeToEnglish => new PatientRecordDetailsCommands(OnChangeToEnglishExecute, OnChangeToEnglishCanExecute);

        public ICommand ChangeToNorwegian => new PatientRecordDetailsCommands(OnChangeToNorwegianExecute, OnChangeToNorwegianCanExecute);
        #endregion

        #region Handlers: Commands
        private void OnPatientRecordDetailsCommandsExecute(object parameter)
        {
            SelectedViewModel = new AddPatientRecordDetailsViewModel();
        }

        private bool OnPatientRecordDetailsCommandsCanExecute(object parameter)
        {
            return true;
        }

        private void OnChangeToEnglishExecute(object parameter)
        {
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            //MenuItem menuItem = (Visual)parameter as MenuItem;
            //menuItem.IsChecked = false;           

        }

        private bool OnChangeToEnglishCanExecute(object parameter)
        {
            return true;
        }

        private void OnChangeToNorwegianExecute(object parameter)
        {
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ng-NO");
            //MenuItem menuItem = (Visual)parameter as MenuItem;
            //menuItem.IsChecked = false;
            //m_windowService.RefreshWindow();
        }

        private bool OnChangeToNorwegianCanExecute(object parameter)
        {
            return true;
        }
        #endregion

        #region Handlers: Members
        //private void ShowSelectedItem()
        //{
        //    MessageBox.Show(m_selectedLanguage.ToString());
        //}
        #endregion

        #region Event Handlers
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
