using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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

            this.DataContext = e.Parameter;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.GoBack();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //using (SQLiteConnection connection =
            //    new SQLiteConnection(new SQLitePlatformWinRT(), App.SQLitePath))
            //{
            //    connection.Delete(this.DataContext as Model.Contato);
            //}
            //this.Frame.GoBack();
        }
    }
}
