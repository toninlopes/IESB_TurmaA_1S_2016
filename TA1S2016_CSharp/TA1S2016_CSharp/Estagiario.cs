using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    public class Estagiario : Funcionario
    {
        public override double Bonificacao
        {
            get { return 0.0; }
        }
    }
}
