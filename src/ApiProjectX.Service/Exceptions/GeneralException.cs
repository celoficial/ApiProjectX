using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Exceptions
{
    class GeneralException : Exception
    {
        public GeneralException():base("Deu ruim")
        {
        }
    }
}
