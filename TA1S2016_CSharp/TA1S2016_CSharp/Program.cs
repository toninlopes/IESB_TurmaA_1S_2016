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
            Conta contaDoCiclano = new Conta();
            contaDoCiclano.Nome = "Ciclano de Tal";
            contaDoCiclano.Deposita(250);
            contaDoCiclano.Deposita(250);

            Conta contaDoFulano = new Conta();
            contaDoFulano.Nome = "Fulano de Tal";
            contaDoFulano.Deposita(1000);

            contaDoFulano.Transfere(contaDoCiclano, 500);

            Console.WriteLine($"Saldo do {contaDoCiclano.Nome}: {contaDoCiclano.Saldo}");
            Console.WriteLine($"Saldo do {contaDoFulano.Nome}: {contaDoFulano.Saldo}");
        }
    }
}
