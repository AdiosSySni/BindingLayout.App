using System.Net.NetworkInformation;

namespace BindingLayout;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();

    }

	//public async void FilePickerButton(object sender, EventArgs e)
	//{
 //       var result = await FilePicker.PickAsync(new PickOptions
	//	{
	//		PickerTitle = "Выберите изображение",
	//		FileTypes = FilePickerFileType.Images
            
 //       });
	//	if (result == null)
	//		return;	

	//	var stream = await result.OpenReadAsync();
	//	myImage.Source = ImageSource.FromStream(() => stream);

	//}

    public void ClickButton(object sender, EventArgs e)
	{
        //Person person = new Person()
        //{
        //    Name = NameEntry.Text,
        //    Surname = SurnameEntry.Text,
        //    ThirdName = ThirdNameEntry.Text 
        //};

        Preferences.Default.Set("Name", NameEntry.Text);
        Preferences.Default.Set("Surname", SurnameEntry.Text);
        Preferences.Default.Set("ThirdName", ThirdNameEntry.Text);
        Preferences.Default.Set("URL", ImageURL.Text);

        Navigation.PushAsync(new NewPage1());

    }
}

