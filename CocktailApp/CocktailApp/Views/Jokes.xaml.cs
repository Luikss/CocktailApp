namespace Views;

public partial class Jokes : ContentPage
{
	public Jokes()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        jokes.ItemsSource = JokeService.GetJokes();
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HomePage());
}