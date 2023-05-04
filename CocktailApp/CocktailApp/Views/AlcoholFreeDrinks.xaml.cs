namespace Views;

public partial class AlcoholFreeDrinks : ContentPage
{
    public AlcoholFreeDrinks()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        nonAlcoCocktails.ItemsSource = CocktailService.GetNonAlcoholicCoctails();
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HomePage());


    async void Details_Clicked(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new DetailsPage(e.CurrentSelection.First() as Cocktail));
    }
}
