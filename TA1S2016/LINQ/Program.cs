using LINQ.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        public static ObservableCollection<Funcionario> funcionarios =
            new ObservableCollection<Funcionario>();


        ///delegate int Somar(int a, int b);

        static void Main(string[] args)
        {
            LoadData();

            //var funcionariosMaiorQueQuatro1 =
            //    from f in funcionarios
            //    orderby f.Salario descending
            //    where f.Salario > 4000
            //    select f;

            //var funcionariosMaiorQueQuatro2 = funcionarios
            //    .Where( (f) => f.Salario > 4000 )
            //    .OrderByDescending( (f) => f.Salario);

            //foreach (var f in funcionariosMaiorQueQuatro1)
            //{
            //    Console.WriteLine($"{f.Nome} - {f.Salario}");
            //}

            //var todosGerentes1 = from f in funcionarios
            //                    where f is Gerente
            //                    select f;

            //var todosGerentes2 = funcionarios.OfType<Gerente>();

            //foreach (var f in todosGerentes2)
            //{
            //    Console.WriteLine($"{f.Nome} - {f.Salario}");
            //}
            //Console.WriteLine(todosGerentes1.Count());
            //Console.WriteLine(todosGerentes2.Count());

            //var mediaSalarialMkt1 =
            //    (from f in funcionarios
            //     where f.Departamento.Nome == "Marketing"
            //     select f).Average( f => f.Salario);

            //var mediaSalarialMkt2 = funcionarios
            //    .Where(f => f.Departamento.Nome.Equals("Marketing"))
            //    .Select(f => f.Salario)
            //    .Average();

            //Console.WriteLine(mediaSalarialMkt1);
            //Console.WriteLine(mediaSalarialMkt2);

            //var deptosAgrupados1 =
            //    from f in funcionarios
            //    group f by f.Departamento.Nome into g
            //    select new
            //    {
            //        Depto = g.Key,
            //        Qtde = g.Count()
            //    };

            //var deptosAgrupados2 = funcionarios
            //    .GroupBy(f => f.Departamento.Nome)
            //    .Select((grp) => new
            //    {
            //        Depto = grp.Key,
            //        Qtde = grp.Count()
            //    });

            //foreach (var item in deptosAgrupados2)
            //    Console.WriteLine($"{item.Depto} - {item.Qtde}");


            var faixaSalarial1 = from f in funcionarios
                                 group f by new
                                 {
                                     Faixa = f.Salario >= 4000 ? "Faixa A" :
                                     f.Salario < 2000 ? "Faixa C" : "Faixa B"
                                 } into g
                                 select new
                                 {
                                     Faixa = g.Key,
                                     Qtde = g.Count()
                                 };

            //var faixaSalarial2 = funcionarios
            //    .GroupBy( f => new
            //    {
            //        Faixa = f.Salario >= 4000 ? "Faixa A" :
            //        f.Salario < 2000 ? "Faixa C" : "Faixa B"
            //    })
            //    .Select()

            //foreach (var sal in faixaSalarial1)
            //    Console.WriteLine($"{sal.Faixa} - {sal.Qtde}");


            //var funcPorFaixaSalarial = funcionarios
            //    .GroupBy(f =>
            //    {
            //        return f.Salario >= 4000 ? "Faixa A" :
            //        f.Salario < 2000 ? "Faixa C" : "Faixa B";
            //    })
            //    .Select(g => new
            //    {
            //        Grupo = g.Key,
            //        Qtde = g.Count()
            //    });

            //foreach (var item in funcPorFaixaSalarial)
            //{
            //    Console.WriteLine($"{item.Grupo} - {item.Qtde}");
            //}

            int[] inteiros =
                new int[] { 1, 2, 2, 2, 3, 3, 5, 8, 9, 9 };

            var distintos = inteiros
                .Distinct()
                .OrderByDescending( i => i);

            foreach (var item in distintos)
                Console.WriteLine($"{item}");

            Console.ReadLine();
        }


        #region Load Data
        private static void LoadData()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "dd/MM/yyyy";

            string pasta = Path.GetDirectoryName(
                Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var arquivo = Path.Combine(pasta, "Data", "Gerente.json");
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string json = sr.ReadToEnd();
                var registries = JsonConvert.DeserializeObject<ObservableCollection<Funcionario>>(json, settings);

                funcionarios = new ObservableCollection<Funcionario>(registries);
            }

            arquivo = Path.Combine(pasta, "Data", "Gerente.json");
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string json = sr.ReadToEnd();
                var registries = JsonConvert.DeserializeObject<ObservableCollection<Gerente>>(json, settings);

                var list = funcionarios.Concat(registries);
                funcionarios = new ObservableCollection<Funcionario>(list);
            }
        }
        #endregion
    }
}
