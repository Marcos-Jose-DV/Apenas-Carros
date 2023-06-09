namespace Apenas_Carros.View;
using Apenas_Carros.ViewModels;

public partial class CarrosPage : ContentPage
{
	public CarrosPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}