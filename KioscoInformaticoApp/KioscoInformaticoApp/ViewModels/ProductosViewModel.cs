using CommunityToolkit.Mvvm.Messaging;
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
    public class ProductosViewModel : ObjectNotification
    {
        private GenericService<Producto> productoService= new GenericService<Producto>();
		private string filterProducts;

		public string FilterProducts
		{
			get { return filterProducts; }
			set { filterProducts = value; 
				OnPropertyChanged();
				_=FilterProductos();
			}
		}
        //porque hacemos esto, porque lo dijo Gabriel
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
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


        private ObservableCollection<Producto> productos;

        public ObservableCollection<Producto> Productos
        {
            get { return productos; }
            set { productos = value;
                OnPropertyChanged();}

        }

        private List<Producto>? productosListToFilter;
        private Producto selectedProduct;

        public Producto SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; 
            OnPropertyChanged();
            EditarProductCommand.ChangeCanExecute();
            }
        }


        public Command GetProductsCommand { get; }
        public Command FilterProductsCommand { get; }
        public Command AddProductCommand { get; }
        public Command EditarProductCommand { get; }  

        public ProductosViewModel()
        {
            GetProductsCommand = new Command (async () => await GetProductos());
            FilterProductsCommand = new Command(async () => await FilterProductos());
            AddProductCommand = new Command (async () => await AddProductos());
            EditarProductCommand = new Command(async (obj) => await EditarProductos(),PermitirEditar);
            GetProductos();
        }

        private bool PermitirEditar(object arg)
        {
            return SelectedProduct != null;
        }

        private async Task EditarProductos()
        {
            var navigationParameters = new ShellNavigationQueryParameters
            {
                { "Producto", SelectedProduct }
            };
            await Shell.Current.GoToAsync("//AddEditProductoPage", navigationParameters);
        }

        private async Task AddProductos()
        {
            var navigationParameters = new ShellNavigationQueryParameters
            {
                { "Producto", null }
            };
            await Shell.Current.GoToAsync("//AddEditProductoPage", navigationParameters);
        }

        private async Task FilterProductos()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.ToUpper().Contains(filterProducts.ToUpper()));
            
            Productos = new ObservableCollection<Producto>(productosFiltrados);
        }

        public async Task GetProductos()
        {
            FilterProducts = string.Empty;
            IsRefreshing= true;
            productosListToFilter= await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            IsRefreshing = false;
        } 
    }


}
