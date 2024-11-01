using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AddEditProductoView : ContentPage
{
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