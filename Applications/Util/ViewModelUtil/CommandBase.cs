using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Util.ViewModelUtil
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _fun;
        private bool _canExec = true;

        public CommandBase(Action fun)
        {
            _fun = fun;
        }

        

        public virtual bool CanExecute(object parameter)
        {
            return _canExec;
        }

        public virtual void Execute(object parameter)
        {
            _canExec = false;
            _fun.Invoke();
            _canExec = true;
        }
    }
}
