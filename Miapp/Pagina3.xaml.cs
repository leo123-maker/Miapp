namespace Miapp;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
	private async void Back_Clicked(object sender, EventArgs e)
	{

		await Navigation.PopAsync();

    }
}