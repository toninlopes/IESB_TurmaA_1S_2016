using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1S2016_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta contaDoCiclano =
            //    new Conta("Ciclano de Tal", 500, 1000);

            //Console.WriteLine(
            //    $"Saldo de {contaDoCiclano.Nome} é {contaDoCiclano.Saldo}");

            //contaDoCiclano.Deposita(250);
            //contaDoCiclano.Deposita(250);

            //Conta contaDoFulano = new Conta();
            //contaDoFulano.Nome = "Fulano de Tal";
            //contaDoFulano.Deposita(1000);

            //contaDoFulano.Transfere(contaDoCiclano, 500);

            //Console.WriteLine($"Saldo do {contaDoCiclano.Nome}: {contaDoCiclano.Saldo}");
            //Console.WriteLine($"Saldo do {contaDoFulano.Nome}: {contaDoFulano.Saldo}");


            //Funcionario func = new Funcionario();
            //func.Salario = 5000;
            //Console.WriteLine($"Funcionário {func.Bonificacao}");

            //Gerente ger = new Gerente();
            //ger.Salario = 5000;
            //Console.WriteLine($"Gerente {ger.Bonificacao}");

            Funcionario estagiario = new Estagiario();
            estagiario.Nome = "Beltrano de Tal";
            estagiario.Salario = 500.0;
            ImprimeSalario(estagiario);

            Funcionario secretaria = new Secretaria();
            secretaria.Nome = "Ciltrano de Tal";
            secretaria.Salario = 1500.0;
            ImprimeSalario(secretaria);

            Funcionario coordenador = new Coordenador();
            coordenador.Nome = "Deltrano de Tal";
            coordenador.Salario = 2500.0;
            ImprimeSalario(coordenador);

            Funcionario gerente = new Gerente();
            gerente.Nome = "Eltrano de Tal";
            gerente.Salario = 3500.0;
            ImprimeSalario(gerente);

            Funcionario diretor = new Diretor();
            diretor.Nome = "Fulano de Tal";
            diretor.Salario = 5000.0;
            ImprimeSalario(diretor);

            Funcionario presidente = new Presidente();
            presidente.Nome = "Zelano de Tal";
            presidente.Salario = 10000.0;
            ImprimeSalario(presidente);

            Conta conta = new Conta();
            conta.Limite = 500;

            try
            {
                conta.Saca(800);
            }
            catch (Excecoes.SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Excecoes.ValorInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        private static void ImprimeSalario(Funcionario funcionario)
        {
            Console.WriteLine($"Funcionário: {funcionario.Nome}");
            Console.WriteLine($"Salário: {funcionario.Salario}");
            Console.WriteLine($"Bonficação: {funcionario.Bonificacao}");
            Console.WriteLine();
        }
    }
}
