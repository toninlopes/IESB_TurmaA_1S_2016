using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contatos.ViewModel
{
    public class ConfiguracoesViewModel
    {
        public ConfiguracoesViewModel()
        {
            this.AuthenticateCommand =
                new Commands.ActionCommand(this.AuthenticateAsync);
        }

        public ICommand AuthenticateCommand { get; private set; }
        private async void AuthenticateAsync()
        {
            try
            {
                MobileServiceUser user =
                    await App.mobileService
                    .LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                App.mobileService.CurrentUser = user;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
