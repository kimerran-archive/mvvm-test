using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm.ViewModel.Common
{
    public class MvvmCommand : ICommand
    {
        private readonly Func<object, bool> _canExecute;
        private readonly Action<object> _executeAction;

        public MvvmCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //if (CanExecuteChanged != null)
            //{
            //    CanExecuteChanged(this, new EventArgs());
            //}
            //return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
