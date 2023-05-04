namespace Views;

public partial class AlcoholFreeDrinks : ContentPage
{
    public AlcoholFreeDrinks()
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