namespace KioscoInformaticoApp;
using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoApp.Views;
using System;

public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false;  // Oculta el menú lateral
            RegisterRouter(); // Registra el router de mensajes
    }

    private void RegisterRouter()
    {
        Routing.RegisterRoute("Registrarse", typeof(RegistrarseView)); // Registra la ruta de la página de registro
    }

    public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }

        #region Centro de mensajes deshabilitado
        // En el constructor de la clase
        //WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        //{
        //    OnReceiveMessage(mensaje);
        //});

        //private async void OnReceiveMessage(Message mensaje)
        //{
        //    if (mensaje.Value == "AbrirProductos")
        //    {
        //        //await Navigation.PushAsync(new ProductosView());
        //    }
        //    if (mensaje.Value == "AbrirOfertas")
        //    {
        //        //await Navigation.PushAsync(new ProductosOfertaView());
        //    }
        //    if (mensaje.Value == "AgregarProducto")
        //    {
        //        //await Navigation.PushAsync(new AgregarEditarProductoView(mensaje.ProductoAEditar));
        //    }
        //    if (mensaje.Value == "EditarProducto")
        //    {
        //        //await Navigation.PushAsync(new AgregarEditarProductoView(mensaje.ProductoAEditar));
        //    }
        //    if (mensaje.Value == "AbrirKioscoShell")
        //    {
        //        //await Navigation.PushAsync(new KioscoShell());
        //    }
        //}
        #endregion
    }

