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
            string apiKey = "eyJhbGciOiJSUzI1NiIsImtpZCI6IiIsInR5cCI6IkpXVCJ9.eyJkYXRhY2VudGVyIjoidXMiLCJrZXkiOiI1YTg5ODk2NTQ3ZWM5ODFiY2E0ZWFkYjFiZmVlYjMzZTlmM2YyMDdiZWU3Mjk4NGUxOThjYjVlODhlYWFkY2VjOWQyNmZkZDIwNGFkOGQ3ZGIyMTVhYjFjZDJiODJjZTI4YmIzYmFjYzExNzRkODNjYzE4NThmMWQxNTBhNTk2OC45YjI1YTIxNTQ4OTY4ZmUyY2E5YTc1ZGQ4ZWJmNGQxNS4xYjFlYmQ5NDU3MjEyODkzMzg4YjgzNzVkZmQyY2EyOGQzN2NmNTdkODFjNjNkNjFmMWI4NjYzNDE2ZGUwMDc0In0.Iua2npvVckTNxft1jJGBis4N_qNzlU0GPn5Wlh0E9mFxJN1ZpfxAy23bWkwtA07xWvq2CpEZ6lDWzLdy7c2je8oXYDSJMwn7Kl4FUdNkJIvpN2PfwGKht9BR5rfGUnqderN52VWXh8zWgh38uYxyel3kozmmfm_XsN0sYOwiTJ4";
            Pendo.SetDebugMode(true);
            Pendo.Setup(apiKey);
        }

       
    
}
}
