namespace BindingLayout;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        Name.Text = Preferences.Default.Get("Name", "Unknown");
        Surname.Text = Preferences.Default.Get("Surname", "Unknown");
        ThirdName.Text = Preferences.Default.Get("ThirdName", "Unknown");
        Image.Source = Preferences.Default.Get("URL", "Unknown");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
                
    }

}