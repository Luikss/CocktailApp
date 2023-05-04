namespace Views;

public partial class Jokes : ContentPage
{
	public Jokes()
	{
		InitializeComponent();
	}

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}