using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Util.ModelUtil
{
    [JsonObject(MemberSerialization.OptIn)]
    public interface IModel
    {
    }
}
