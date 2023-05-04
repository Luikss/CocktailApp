namespace Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Cocktail cocktail)
	{
        InitializeComponent();
        BindingContext = cocktail;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
