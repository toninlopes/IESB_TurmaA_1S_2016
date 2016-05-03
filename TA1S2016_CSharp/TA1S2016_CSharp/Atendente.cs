using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    public class Atendente : Funcionario
    {
        public override double Bonificacao
        {
            get { return this.Salario * 0.05; }
        }
    }
}
