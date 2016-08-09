using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
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

namespace Contatos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Contato : Page
    {
        public Contato()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter != null &&
                e.Parameter is Model.Contato)
            {
                this.DataContext = e.Parameter as Model.Contato;
            }
            else
            {
                this.DataContext = new Model.Contato();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //using (SQLiteConnection connection =
            //    new SQLiteConnection(new SQLitePlatformWinRT(), App.SQLitePath))
            //{
            //    connection.Delete(this.DataContext as Model.Contato);
            //}
            this.Frame.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //using (SQLiteConnection connection =
            //    new SQLiteConnection(new SQLitePlatformWinRT(), App.SQLitePath))
            //{
            //    connection.InsertOrReplace(this.DataContext as Model.Contato);
            //}
            this.Frame.GoBack();
        }
    }
}
