using System;

namespace TA1S2016_CSharp
{
    public class Gerente : Funcionario
    {
        private int numeroDeSubordinados;

        public int NumeroDeSubordinados
        {
            get { return numeroDeSubordinados; }
            set { numeroDeSubordinados = value; }
        }

        public override double Bonificacao
        {
            get { return this.Salario * 0.15; }
        }
    }
}
