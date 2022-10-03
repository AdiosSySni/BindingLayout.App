using System.Collections.ObjectModel;

namespace BindingLayout;

public partial class NewPage2 : ContentPage
{
    public ObservableCollection<String> Test { get; set; }
    public NewPage2()
    {
        
        Test = new ObservableCollection<string> { "one", "two", "three" };
        BindingContext = this;
        InitializeComponent();
    }

    private void OnClicked(object sender, EventArgs e)
    {

        Test.Add("new elem");
    }

    private async void BackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}