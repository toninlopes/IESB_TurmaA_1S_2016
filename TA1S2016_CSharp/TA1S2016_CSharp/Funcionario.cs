using System;

namespace TA1S2016_CSharp
{
    public class Funcionario
    {
        string nome;
        string sobrenome;
        string cpf;
        DateTime  dataNascimento;
        double salario;

        public virtual double Bonificacao
        {
            get { return this.salario * 0.10; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}
