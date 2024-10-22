using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    internal class AddEditProductoViewModel : ObjectNotification
    {
        ProductoService productoServicw = new ProductoService();
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;

        public decimal Preio

        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }

        public bool oferta;

        public bool Oferta
        {
            get { return oferta; }
            set
            {
                oferta = value;
                OnPropertyChanged();
            }
        }

        public Command SaveProductCommand { get; }

        public AddEditProductoViewModel()
        {
            SaveProductCommand = new Command(async () => await SaveProducto());
        }

        private async Task SaveProducto()
        {
            var producto = new Producto()
            {
                Nombre = this.Nombre,
                Precio = this.Preio,
                Oferta = this.Oferta
            };
            await productoServicw.AddAsync(producto);
            WeakReferenceMessenger.Default.Send(new Message("CerrarVentana"));
        }
    }
}
