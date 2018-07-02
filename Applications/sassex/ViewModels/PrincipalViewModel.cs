using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sassex.ViewModels
{
    public class PrincipalViewModel
    {
        private string _text;

        public string TestText
        {
            get
            {
                return _text;
            }

            set
            {
                if (_text != value)
                    _text = value;
            }
        }

        public PrincipalViewModel()
        {
            _text = "Hola Mundo!!!";
        }
    }
}
