using System;

namespace LINQ.Model
{
    public class Funcionario
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }
        private string sobrenome;
        public string Sobrenome
        {
            get { return this.sobrenome; }
            set { this.sobrenome = value.ToUpper(); }
        }

        public string NomeCompleto
        {
            get { return $"{this.Nome} {this.Sobrenome}"; }
        }

        private DateTime dataAdmissao;
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public virtual double Salario
        {
            get;
            set;
        }

        public Departamento Departamento { get; set; }
    }
}
