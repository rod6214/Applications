using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ViewModelUtil
{
    public class Command : CommandBase
    {
        public Command(Action fun) : base(fun)
        {
        }
    }
}
