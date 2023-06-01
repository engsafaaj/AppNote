using AppNote.Data;
using AppNote.ViewModels;
using AppNote.Views;
using Microsoft.Extensions.Logging;

namespace AppNote;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		// DataBase Created
		DBContext dbContext = new DBContext();
		dbContext.Database.EnsureCreated();
		//
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		// Singleton
		builder.Services.AddSingleton<NoteView>();
		builder.Services.AddSingleton<NoteViewModel>();

		

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
