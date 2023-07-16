using LomasZumarraga_ProyectoFinal.Data;

namespace LomasZumarraga_ProyectoFinal;

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

        string dbPath1 = FileAccessHelper.GetLocalFilePath("people.db1");
        string dbPath2 = FileAccessHelper1.GetLocalFilePath("people.db2");
        string dbPath3 = FileAccessHelper2.GetLocalFilePath("people.db3");
        string dbPath4 = FileAccessHelper3.GetLocalFilePath("people.db4");
        builder.Services.AddSingleton<TecDatabase>(s => ActivatorUtilities.CreateInstance<TecDatabase>(s, dbPath1));
        builder.Services.AddSingleton<ArtDatabase>(s => ActivatorUtilities.CreateInstance<ArtDatabase>(s, dbPath2));
        builder.Services.AddSingleton<CultDatabase>(s => ActivatorUtilities.CreateInstance<CultDatabase>(s, dbPath3));
        builder.Services.AddSingleton<DepDatabase>(s => ActivatorUtilities.CreateInstance<DepDatabase>(s, dbPath4));


        return builder.Build();
	}
}
