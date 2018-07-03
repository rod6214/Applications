using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.ModelUtil;

namespace Util.ViewModelUtil
{
    public interface IViewModel
    {
        IModel GetModel();
        void SetModel(IModel model);
    }
}
