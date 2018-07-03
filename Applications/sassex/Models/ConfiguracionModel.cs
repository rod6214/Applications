using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Util.ModelUtil;
using Util.Enums;

namespace sassex.Models
{
    public class ConfiguracionModel : IModel 
    {
        #region Properties
        [JsonProperty("InDt")]
        public string InputDirectory { get; set; }
        [JsonProperty("LaNg")]
        public Language Lang { get; set; }
        #endregion

        #region Constructors
        public ConfiguracionModel()
        {
            InputDirectory = @"";
            Lang = Language.SPANISH;
        }
        #endregion
    }
}
