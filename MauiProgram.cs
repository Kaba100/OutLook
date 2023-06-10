using Microsoft.Extensions.Logging;
using OutLook.Page;
using OutLook.ViewModel;

namespace OutLook;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Gilroy-Bold.ttf", "GilroyBold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<NextPage>();
		builder.Services.AddTransient<FleshVM>();
		builder.Services.AddTransient<IngredientVM>();
		builder.Services.AddTransient<RecipesVM>();


		builder.Services.AddTransient<MealsPage>();
		builder.Services.AddTransient<MealsVM>();


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
