namespace Views;

public partial class AlcoholicDrinks : ContentPage
{
    public AlcoholicDrinks()
	{
		InitializeComponent();
	}

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    // NEEDS Button in XAML
    async void Details_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new DetailsPage());
}