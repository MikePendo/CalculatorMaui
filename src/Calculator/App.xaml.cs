namespace Calculator;
using PendoMAUIPlugin;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

    protected override void OnStart()
    {
        IPendoService Pendo = PendoServiceFactory.CreatePendoService();

        /** if your app supports additional Platforms other than iOS and Android
        verify the Pendo instance is not null */
        if (Pendo != null)
        {
            string apiKey = "key";
            Pendo.SetDebugMode(true);
            Pendo.Setup(apiKey);
        }

       
    
}
}
