namespace CocktailApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
				fonts.AddFont("Nunito-Italic.ttf", "NunitoItalic");
				fonts.AddFont("Nunito-Light.ttf", "NunitoLight");
				fonts.AddFont("Nunito-Medium.ttf", "NunitoMedium");
				fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
				fonts.AddFont("Nunito-SemiBold.ttf", "NunitoSemiBold");
			});

		return builder.Build();
	}
}
