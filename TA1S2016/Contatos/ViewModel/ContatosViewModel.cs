using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contatos.ViewModel
{
    public class ContatosViewModel
    {
        public static string SQLitePath =
            Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
                "database.sqlite");

        public ObservableCollection<Model.Contato> ListaContatos { get; set; }
        public ObservableCollection<Model.Contato> ListaContatosFavoritos { get; set; }

        public Model.Contato SelectedContato { get; set; }

        public ContatosViewModel()
        {
            using (SQLite.Net.SQLiteConnection connection =
                new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), SQLitePath))
            {
                connection.CreateTable<Model.Contato>();

                this.ListaContatos =
                    new ObservableCollection<Model.Contato>
                    (connection.Table<Model.Contato>());

                this.ListaContatosFavoritos =
                    new ObservableCollection<Model.Contato>
                    (ListaContatos.Where(c => c.IsFavorito));
            }

            this.IncluirCommand = new Commands.ActionCommand(Incluir);
            this.SalvarCommand = new Commands.ActionCommand(Salvar);
        }

        public ICommand IncluirCommand { get; private set; }

        private void Incluir()
        {
            this.SelectedContato = new Model.Contato();
            App.RootFrame.Navigate(typeof(Contato), this);
        }

        public ICommand SalvarCommand { get; private set; }
        private void Salvar()
        {
            using (SQLite.Net.SQLiteConnection connection =
                new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), SQLitePath))
            {
                connection.InsertOrReplace(this.SelectedContato);
            }

            App.RootFrame.GoBack();
        }
    }
}
