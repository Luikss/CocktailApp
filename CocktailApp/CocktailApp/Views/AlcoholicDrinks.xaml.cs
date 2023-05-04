using Services;

namespace Views;

public partial class AlcoholicDrinks : ContentPage
{
    public AlcoholicDrinks()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        alcoCocktails.ItemsSource = CocktailService.GetAlcoholicCoctails();
    }

    // NEEDS Button in XAML
    async void Details_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new DetailsPage());
}