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
    public sealed partial class Configuracoes : Page
    {
        Windows.Storage.ApplicationDataContainer dataStorage
            = Windows.Storage.ApplicationData.Current.RoamingSettings;

        public Configuracoes()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (dataStorage.Values.ContainsKey(NomeCompleto.Name))
                NomeCompleto.Text = dataStorage.Values[NomeCompleto.Name] as string;

            if (dataStorage.Values.ContainsKey(PushNotification.Name))
                PushNotification.IsOn = (bool)dataStorage.Values[PushNotification.Name];
        }

        private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dataStorage.Values.ContainsKey(NomeCompleto.Name))
                dataStorage.Values[NomeCompleto.Name] = NomeCompleto.Text;
            else
                dataStorage.Values.Add(NomeCompleto.Name, NomeCompleto.Text);
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (dataStorage.Values.ContainsKey(PushNotification.Name))
                dataStorage.Values[PushNotification.Name] = PushNotification.IsOn;
            else
                dataStorage.Values.Add(PushNotification.Name, PushNotification.IsOn);
        }
    }
}
