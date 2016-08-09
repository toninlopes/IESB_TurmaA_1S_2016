using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.ViewModel
{
    public class ContatosViewModel
    {
        public static string SQLitePath =
            Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "database.sqlite");

        public ObservableCollection<Model.Contato> ListaContatos { get; set; }
        public ObservableCollection<Model.Contato> ListaContatosFavoritos { get; set; }

        public Model.Contato SelectedContato { get; set; }

        public ContatosViewModel()
        {
            using (SQLite.Net.SQLiteConnection connection =
                new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), SQLitePath))
            {
                connection.CreateTable<Model.Contato>();

                ListaContatos =
                    new ObservableCollection<Model.Contato>
                    (connection.Table<Model.Contato>());

                ListaContatosFavoritos =
                    new ObservableCollection<Model.Contato>
                    (ListaContatos.Where(c => c.IsFavorito));
            }
        }
    }
}
