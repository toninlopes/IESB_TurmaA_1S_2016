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
        public static ObservableCollection<Funcionario> funcionarios = new ObservableCollection<Funcionario>();

        static void Main(string[] args)
        {
            
        }

        #region Load Data
        private static void LoadData()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "dd/MM/yyyy";

            string pasta = Path.GetDirectoryName(
                Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var arquivo = Path.Combine(pasta, "Data", "Funcionario.json");
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
