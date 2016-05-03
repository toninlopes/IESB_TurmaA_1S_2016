using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    public class Diretor : Funcionario,  IAutenticavel
    {
        public override double Bonificacao
        {
            get { return this.Salario * 0.25; }
        }

        public string Senha { get; set; }

        public bool Autentica(string senha)
        {
            return this.Senha.Equals(senha);
        }
    }
}
