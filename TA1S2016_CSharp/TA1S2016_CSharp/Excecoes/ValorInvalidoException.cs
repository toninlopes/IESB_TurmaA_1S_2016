using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp.Excecoes
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(string message)
            : base(message)
        {

        }
    }
}
