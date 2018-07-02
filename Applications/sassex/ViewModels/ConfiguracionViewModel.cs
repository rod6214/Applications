using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Util.ViewModelUtil;
using Util.Configuration;
using Util.Enums;
using sassex.Models;

namespace sassex.ViewModels
{
    public class ConfiguracionViewModel : ViewModelBase
    {
        #region Fields
        private ConfiguracionModel _configuration;
        private object _locker;
        #endregion

        #region Commands
        public Command Buscar => new Command(BuscarEvent);

        public Command Guardar => new Command(GuardarEvent);
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
            _locker = new object();
            PropertyChanged += ConfiguracionViewModel_PropertyChanged;
            _configuration = ConfigurationManager.ObjectDeserializer(typeof(ConfiguracionModel),ConfigurationRoot.DEFAULTROOT, _locker) 
                as ConfiguracionModel ?? new ConfiguracionModel();
        }
        #endregion

        #region Methods
        public void Save()
        {
            ConfigurationManager.ObjectSerializer(_configuration, ConfigurationRoot.DEFAULTROOT, _locker);
        }
        private void BuscarEvent()
        {
            
        }
        private void GuardarEvent()
        {
            Save();
        }
        private void ConfiguracionViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }
        #endregion
    }
}
