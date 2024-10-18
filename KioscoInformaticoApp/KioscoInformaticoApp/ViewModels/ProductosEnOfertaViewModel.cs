using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosEnOfertaViewModel : ObjectNotification
    {
        private ProductoService productService = new ProductoService();
        private string filterProducts;

        public string FilterProducts
        {
            get { return filterProducts; }
            set
            {
                filterProducts = value;
                OnPropertyChanged();
                FiltrarProductos();
            }
        }

        private ObservableCollection<Producto> products;

        public ObservableCollection<Producto> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }



        private List<Producto>? ProductListToFilter;

        private bool activityStart;

        public bool ActivityStart
        {
            get { return activityStart; }
            set
            {
                activityStart = value;
                OnPropertyChanged();
            }
        }


        public Command GetProductsCommand { get; }
        public Command FilterProductsCommand { get; }

        public ProductosEnOfertaViewModel()
        {
            GetProductsCommand = new Command(async () => await GetProducts());
            FilterProductsCommand = new Command(async () => await FiltrarProductos());
            GetProducts();
        }

        private async Task FiltrarProductos()
        {
            var productsLeaked = ProductListToFilter.Where(p => p.Nombre.ToLower().Contains(filterProducts.ToLower()));
            Products = new ObservableCollection<Producto>(productsLeaked);
        }

        private async Task GetProducts()
        {
            FilterProducts = string.Empty;
            ActivityStart = true;
            ProductListToFilter = await productService.GetAllInOfferAsync();
            Products = new ObservableCollection<Producto>(ProductListToFilter);
            ActivityStart = false;
        }
    }
}
