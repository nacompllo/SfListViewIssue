namespace SfListViewIssue;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Routing.RegisterRoute(nameof(SfListViewIssue.MainPage), typeof(MainViewModel));
    }
}