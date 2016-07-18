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

namespace Publicacao
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WrappedMenu : Page
    {
        public new Frame Frame => App.RootFrame;

        public WrappedMenu()
        {
            this.InitializeComponent();

            this.Frame.Navigated += Frame_Navigated;
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.MySplitView.Content = this.Frame;
        }

        private void btnMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
    }
}
