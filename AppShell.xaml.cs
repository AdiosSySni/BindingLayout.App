namespace BindingLayout;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("nwpg1", typeof(NewPage1));

        
    }
}
