namespace Miapp;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}
	private async void Back_Clicked(object sender, EventArgs a)
	{
		await Navigation.PopAsync();

    }
	private async void GoToPage3_Clicked(object sender, EventArgs a)
	{ 
	
	await Navigation.PushAsync(new Pagina3());

    }

}