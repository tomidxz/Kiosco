using CommunityToolkit.Mvvm.Messaging;
using Firebase.Auth.Repository;
using Firebase.Auth;
using KioscoInformaticoApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth.Providers;
//using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;

namespace KioscoInformaticoApp.ViewModels
{
    public partial class IniciarSesionViewModel : ObservableObject
    {
        public readonly FirebaseAuthClient _clientAuth;
        private FileUserRepository _userRepository;
        private UserInfo _userInfo;
        private FirebaseCredential _firebaseCredential;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string mail;


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string password;


        [ObservableProperty]
        private bool recordarContraseña;


        public IRelayCommand IniciarSesionCommand { get; }
        public IRelayCommand RegistrarseCommand { get; }

        public IniciarSesionViewModel()
        {
            _clientAuth = new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyDjMwp-tMlZzDy66OM6G_r3xbkvBI5PEFw",
                AuthDomain = "kioscoinformatico-4cf58.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            });
            _userRepository = new FileUserRepository("KioscoInformaticoApp");
            ChequearSiHayUsuarioAlmacenado();

            IniciarSesionCommand = new RelayCommand(IniciarSesion,PermitirIniciarSesion);
            RegistrarseCommand = new RelayCommand(Registrarse);
            // RegistrarseCommand = new Command(Registrarse,PermitirRegistrarse);
        }

        private async void Registrarse()
        {
            await Shell.Current.GoToAsync("Registrarse");

        }

        private async void ChequearSiHayUsuarioAlmacenado()
        {
            if (_userRepository.UserExists())
            {
                (_userInfo, _firebaseCredential) = _userRepository.ReadUser();

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();
            }
        }


        private bool PermitirIniciarSesion()
        {
            return !string.IsNullOrEmpty(Mail) && !string.IsNullOrEmpty(Password);
        }

        private async void IniciarSesion()
        {

            try
            {

                var userCredential = await _clientAuth.SignInWithEmailAndPasswordAsync(Mail, Password);
                if (userCredential.User.Info.IsEmailVerified == false)
                {
                    await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Debe verificar su correo electrónico", "Ok");
                    return;
                }

                if (recordarContraseña)
                {
                    _userRepository.SaveUser(userCredential.User);
                }
                else
                {
                    _userRepository.DeleteUser();
                }

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();

            }
            catch (Exception error)
            {
                await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Ocurrió un problema:" + error.Message, "Ok");

            }
        }
    }
}
