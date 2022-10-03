namespace BindingLayout;

[QueryProperty(nameof(STR), "input")]
[QueryProperty(nameof(STR), "input2")]
[QueryProperty(nameof(STR), "input3")]
public partial class NewPage1 : ContentPage
{

    public string STR
    {
        set
        {
            label.Text += value;
        }
    }

	public NewPage1()
	{
		InitializeComponent();
        Surname.Text = Preferences.Default.Get("Surname", "Unknown");
        Name.Text = Preferences.Default.Get("Name", "Unknown");
        ThirdName.Text = Preferences.Default.Get("ThirdName", "Unknown");
        Image.Source = Preferences.Default.Get("URL", "Unknown");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}