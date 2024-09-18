using ExemploHttp.ViewModels;

namespace ExemploHttp.Views;

public partial class PhotosView : ContentView
{
	public PhotosView()
	{
        BindingContext = new PhotosViewModel();
        InitializeComponent();
	}
}