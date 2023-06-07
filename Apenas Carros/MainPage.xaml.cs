using Apenas_Carros.ViewModels;

namespace Apenas_Carros;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}

