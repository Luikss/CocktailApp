namespace Views;

public partial class AlcoholFreeDrinks : ContentPage
{
    public AlcoholFreeDrinks()
	{
		InitializeComponent();
	}

    // NEEDS Button in XAML
    async void Details_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new DetailsPage());
}