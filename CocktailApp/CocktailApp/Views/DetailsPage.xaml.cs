namespace Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();

    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}