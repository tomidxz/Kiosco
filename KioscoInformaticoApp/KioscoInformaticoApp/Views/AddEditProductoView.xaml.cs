using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;
[QueryProperty(nameof(Product), "ProductoAEditar")]
public partial class AddEditProductoView : ContentPage
{
    public Producto Product
    {
        set
        {
            var producto = value;
            var viewModel = this.BindingContext as AddEditProductoViewModel;
            viewModel.EditProduct = producto;
        }
    }
	public AddEditProductoView()
	{
		InitializeComponent();
	}

    public AddEditProductoView(Producto producto)
    {
        InitializeComponent();
        var viewmodel = this.BindingContext as AddEditProductoViewModel;
        viewmodel.EditProduct = producto;
    }
}