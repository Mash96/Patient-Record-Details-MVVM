using System.ComponentModel;
using System.Windows.Input;
using PatientRecordMVVM.Commands;

namespace PatientRecordMVVM.ViewModels
{
    class HomeCareMainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Fields
        private object m_selectedViewModel;
        #endregion

        #region Constructors
        public HomeCareMainViewModel() {}
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
        #endregion

        #region Event Handlers
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
