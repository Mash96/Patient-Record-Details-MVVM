using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using PatientRecordMVVM.Commands;

namespace PatientRecordMVVM.ViewModels
{
    class HomeCareMainViewModel
    {
        public ICommand LogoutCommand => new PatientRecordDetailsCommands(param => OnLogoutCommandExecute(), param => OnLogoutCommandCanExecute());

        private void OnLogoutCommandExecute()
        {
            // MVVM Violation
            Application.Current.Shutdown();
        }

        private bool OnLogoutCommandCanExecute()
        {
            return true;
        }
    }
}
