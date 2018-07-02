using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace sassex.Models
{
    
    [JsonObject(MemberSerialization.OptIn)]
    public class ConfiguracionModel
    {
        #region Properties
        [JsonProperty("InDt")]
        public string InputDirectory { get; set; }
        #endregion

        #region Constructors
        public ConfiguracionModel()
        {
            InputDirectory = @"";
        }
        #endregion
    }
}
