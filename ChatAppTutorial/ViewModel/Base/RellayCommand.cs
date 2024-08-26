using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatAppTutorial.ViewModel
{
    internal class RellayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged = (sender,e) =>{};

        private Action mAction;

        public RellayCommand(Action mAction)
        {

            this.mAction = mAction;

        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
