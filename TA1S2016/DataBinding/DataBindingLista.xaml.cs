using DataBinding.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataBindingLista : Page
    {
        public ObservableCollection<Funcionario>
            Funcionarios { get; set; }

        public DataBindingLista()
        {
            this.InitializeComponent();

            //this.DataContext = App.LoadData();

            Funcionarios = App.LoadData();
            //lvFuncionarios.ItemsSource = this.DataContext;

            //Todos
            PITodos.DataContext = Funcionarios;

            //Salário maior que 2000
            PISalario.DataContext = Funcionarios
                .Where( f => f.Salario > 2000);

            //Deptos igual a Tecnologia
            PIDepto.DataContext = Funcionarios
                .Where(f => f.Departamento.Nome.Equals("Tecnologia"));
        }
    }
}
