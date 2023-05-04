using CocktailApp;

namespace Views;

public partial class HomePage : ContentPage
{
	RestService _restService;

	public HomePage()
	{
		InitializeComponent();
		_restService = new RestService();
		LoadAlcoholicDrinks();
	}

	async void LoadAlcoholicDrinks()
	{
		CocktailData cocktailData = await _restService.GetCocktailData(GenerateRequestURL(Constants.CocktailDBMapEndpoint));

		BindingContext = cocktailData;
	}

	string GenerateRequestURL(string endpoint)
    {
        string requestUri = endpoint;
		requestUri += "filter.php?a=Alcoholic";

		return requestUri;
    }
}