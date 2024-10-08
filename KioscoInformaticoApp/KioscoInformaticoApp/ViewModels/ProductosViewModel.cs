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
       
        private bool activityStart;
        public bool ActivityStart
        {
            get { return activityStart; }
            set { activityStart = value; }
        }

        public Command GetProductsCommand { get; }
        public Command FilterProductsCommand { get; }

        public ProductosViewModel()
        {
            GetProductsCommand = new Command (async () => await GetProductos());
            FilterProductsCommand = new Command(async () => await FilterProductos());
            GetProductos();
        }

        private async Task FilterProductos()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.ToUpper().Contains(filterProducts.ToUpper()));
            
            Productos = new ObservableCollection<Producto>(productosFiltrados);
        }

        private async Task GetProductos()
        {
            FilterProducts = string.Empty;
            ActivityStart= true;
            productosListToFilter= await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            ActivityStart = false;
        } 
    }


}
