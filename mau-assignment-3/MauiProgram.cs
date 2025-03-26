namespace mau_assignment_3;

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

		builder.Services.AddTransient<MainPageModel>();
		builder.Services.AddTransient<IAnimalService, AnimalService>();
		builder.Services.AddTransient<IPropertyValidator, PropertyValidator>();
		builder.Services.AddTransient<IAlertService, AlertService>();
		builder.Services.AddTransient(typeof(IListService<>), typeof(ListService<>)); 

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
