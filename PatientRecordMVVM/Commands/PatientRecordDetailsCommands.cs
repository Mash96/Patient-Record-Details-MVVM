using System;
using System.Windows.Input;

namespace PatientRecordMVVM.Commands
{
    class PatientRecordDetailsCommands : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canexecuteMethod;

        public PatientRecordDetailsCommands(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            _executeMethod = executeMethod;
            _canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_canexecuteMethod != null)
            {
                return _canexecuteMethod(parameter);
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }

        //ICommand
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
