namespace MauiAppHotel_.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Clicked_Button(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PopAsync();

		}catch (Exception ex)

		{
			await DisplayAlertAsync("Ops", ex.Message, "OK");
		}
    }
}