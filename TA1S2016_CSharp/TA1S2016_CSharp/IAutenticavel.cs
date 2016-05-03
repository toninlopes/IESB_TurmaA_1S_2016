using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    public interface IAutenticavel
    {
        string Senha { get; set; }

        bool Autentica(string senha);
    }
}
