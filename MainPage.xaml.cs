using System.Net.NetworkInformation;

namespace BindingLayout;

public partial class MainPage : ContentPage
{
	//int count = 0;
	VerticalStackLayout vs;
	string text;
	Label One;
	public MainPage()
	{
		Color c = new Color();
		c = Color.FromRgb(0, 100, 150);
		Button btn = new Button();
		btn.Clicked += OnCounterClicked;
		btn.Clicked += AddNewPage;
		Image img = new Image() { Source = "dotnet_bot.svg" };
        text = "ThirdElem";
        One = new Label();

		vs = new VerticalStackLayout()
		{
			img, new Label() {Text="FirstElem"}, new Label() {Text="SecondElem"}, btn
        };
		
		vs.BackgroundColor = c;
		this.Content = vs;
		
    }

	public void OnCounterClicked(object sender, EventArgs e)
	{
		Label newLabel = new Label() { Text = $"{text}" };
		(vs.Children[vs.Children.Count - 2] as Label).Text = "not lAST";
		(vs.Children[vs.Children.Count - 3] as Label).Text = vs.Children.Count.ToString();
        vs.Insert(vs.Children.Count-1, newLabel);
		
		//string s =$"<Label Text = \"{text}\"/>";
		//One.LoadFromXaml(s);

	}

	public async void AddNewPage(object sender, EventArgs e)
	{
		// await Shell.Current.GoToAsync("nwpg1");
		await Shell.Current.GoToAsync("nwpg1?input=kyky");
	}

	
}

