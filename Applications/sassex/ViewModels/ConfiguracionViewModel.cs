using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Util.ViewModelUtil;
using sassex.Models;

namespace sassex.ViewModels
{
    public class ConfiguracionViewModel : ViewModelBase
    {
        #region Fields
        private ConfiguracionModel _configuration;
        #endregion

        #region Properties
        public string InputDirectory
        {
            get
            {
                if (_configuration == null)
                    return String.Empty;
                return _configuration.InputDirectory;
            }
            set
            {
                if (_configuration?.InputDirectory != value)
                {
                    _configuration.InputDirectory = value;
                    NotifyPropertyChanged(nameof(InputDirectory));
                }
            }
        }
        #endregion

        #region Constructors
        public ConfiguracionViewModel()
        {
            PropertyChanged += ConfiguracionViewModel_PropertyChanged;
        }
        #endregion

        #region Methods
        private void ConfiguracionViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }
        #endregion
    }
}
