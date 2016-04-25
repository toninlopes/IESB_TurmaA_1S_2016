using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    public class Conta
    {
        private string numero;
        public string Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private DateTime dataAbertura;
        public DateTime DataAbertura
        {
            get { return this.dataAbertura; }
            set { this.dataAbertura = value; }
        }

        private double limite;
        public double Limite
        {
            set { this.limite = value; }
        }

        private double saldo;
        public double Saldo
        {
            get { return this.saldo + this.limite; }
        }

        public Conta()
        {
            this.limite = 100;
        }
        public Conta(string nome)
            : this()
        {
            this.nome = nome;
        }
        public Conta(string numero, string nome)
            : this(nome)
        {
            this.numero = numero;
        }

        public bool Saca(double valor)
        {
            if (valor > (this.saldo + this.limite))
            {
                return false;
            }
            else
            {
                double novoSaldo = this.saldo - valor;
                this.saldo = novoSaldo;
                return true;
            }
        }

        public void Deposita(double valor)
        {
            double novoSaldo = this.saldo + valor;
            this.saldo = novoSaldo;
        }

        public void Transfere(Conta destino, double valor)
        {
            destino.saldo = destino.saldo + valor;
            this.saldo = this.saldo - valor;
        }
    }
}
