using LomasZumarraga_ProyectoFinal.Data;

namespace LomasZumarraga_ProyectoFinal;

public partial class App : Application
{
    public static TecDatabase TecRepo { get; private set; }
    public static ArtDatabase ArtRepo { get; private set; }
    public static CultDatabase CultRepo { get; private set; }
    public static DepDatabase DepRepo { get; private set; }

    public App(TecDatabase repo, ArtDatabase repo1, CultDatabase repo2, DepDatabase repo3)
	{
		InitializeComponent();

		MainPage = new AppShell();

		TecRepo = repo;
		ArtRepo = repo1;
        CultRepo = repo2;
        DepRepo = repo3;
    }
}
