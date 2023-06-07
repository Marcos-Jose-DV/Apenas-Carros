using Apenas_Carros.Data;
using Apenas_Carros.Models;
using Apenas_Carros.ViewModels;
using Microsoft.Extensions.Logging;

namespace Apenas_Carros;

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
			});

		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

		var dbContext = new AppDbContext();
		dbContext.Database.EnsureCreated();
		dbContext.Dispose();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
