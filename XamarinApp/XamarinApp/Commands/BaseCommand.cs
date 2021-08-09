using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XamarinApp.Commands
{
    public abstract class BaseCommand<T> : ICommand
    {
        protected readonly T viewModel;
        public BaseCommand(T viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
