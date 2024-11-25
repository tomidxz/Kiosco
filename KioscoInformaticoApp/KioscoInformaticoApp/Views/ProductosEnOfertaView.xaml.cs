namespace KioscoInformaticoApp.Views;
using KioscoInformaticoApp.ViewModels;

public partial class ProductosEnOfertaView : ContentPage
{
	public ProductosEnOfertaView()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewModel = this.BindingContext as ProductosEnOfertaViewModel;
        viewModel.GetProductsCommand.Execute(null);
    }
}