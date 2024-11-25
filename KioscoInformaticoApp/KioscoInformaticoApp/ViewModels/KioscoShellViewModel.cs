using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public partial class KioscoShellViewModel : ObservableObject
    {
        public IRelayCommand LogoutCommand { get; }

        [ObservableProperty]
        private bool isUserLogout = true;

        public KioscoShellViewModel()
        {
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Logout()
        {
            isUserLogout = true;
            (App.Current.MainPage as KioscoShell).DisableAppAfterLogin();
        }
    }
}
