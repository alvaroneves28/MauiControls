using MauiControls.Models;
using System.Threading.Tasks;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
		DisplayAlert("Alerta Cinto Segurança", "Você selecionou/desselecionou  este acessório", "OK");
    }
}