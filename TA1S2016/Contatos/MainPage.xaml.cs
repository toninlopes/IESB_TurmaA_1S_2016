using SQLite.Net;
using SQLite.Net.Platform.WinRT;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Contatos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            using (SQLiteConnection connection =
                new SQLiteConnection(new SQLitePlatformWinRT(), App.SQLitePath))
            {
                var contatos =
                    new ObservableCollection<Model.Contato>(connection.Table<Model.Contato>());
                lvFavoritos.ItemsSource = contatos.Where(c => c.IsFavorito == true);
                lvTodos.ItemsSource = contatos;
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contato));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (myPivot.SelectedIndex == 0)
            {
                this.Frame.Navigate(typeof(Contato), lvFavoritos.SelectedItem);
            }
            else
            {
                this.Frame.Navigate(typeof(Contato), lvTodos.SelectedItem);
            }
        }

        private void lvTodos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            appBarEdit.IsEnabled = true;
        }

        private void myPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvFavoritos.SelectedItem = null;
            lvTodos.SelectedItem = null;
            appBarEdit.IsEnabled = false;
        }
    }
}
