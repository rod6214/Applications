using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Util.ViewModelUtil;
using Util.Configuration;
using Util.Enums;
using Util.ModelUtil;
using sassex.Models;

namespace sassex.ViewModels
{
    public class ConfiguracionViewModel : ViewModelBase
    {
        #region Fields
        private ConfiguracionModel _configuration;
        private string _inputDirLabel;
        private object _locker;
        #endregion

        #region Properties
        public string InputDirectory
        {
            get
            {
                return _configuration.InputDirectory ?? String.Empty;
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

        public Language Lang
        {
            get { return _configuration.Lang; }
            set
            {
                if (_configuration?.Lang != value)
                {
                    _configuration.Lang = value;
                    NotifyPropertyChanged(nameof(Lang));
                }
            }
        }

        public string InputDirLabel
        {
            get
            {
                return _inputDirLabel ?? String.Empty;
            }
            set
            {
                if (_inputDirLabel != value)
                {
                    _inputDirLabel = value;
                    NotifyPropertyChanged(nameof(InputDirLabel));
                }
            }
        }
        #endregion

        #region Constructors
        public ConfiguracionViewModel()
        {
            _locker = new object();
            Load();
            InputDirLabel = @"Directorio de salida:";
        }
        #endregion

        #region Methods
        public void Save()
        {
            ConfigurationManager.ObjectSerializer(GetModel(), ConfigurationRoot.DEFAULTROOT, _locker);
        }

        public void Load()
        {
            _configuration = ConfigurationManager.ObjectDeserializer(typeof(ConfiguracionModel), ConfigurationRoot.DEFAULTROOT, _locker)
                as ConfiguracionModel ?? new ConfiguracionModel();
            SetModel(_configuration);
        }
        #endregion
    }
}
