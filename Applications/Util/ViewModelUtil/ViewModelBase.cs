using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Util.ModelUtil;

namespace Util.ViewModelUtil
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IViewModel
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Fields
        private IModel _model;
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public ViewModelBase()
        {
        }
        #endregion

        #region Methods
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual IModel GetModel() { return _model; }

        public virtual void SetModel(IModel model) { _model = model; }
        #endregion
    }
}
