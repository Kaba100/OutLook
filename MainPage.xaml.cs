namespace OutLook;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Clicked_Signup(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("NewPage1");
    }

    private void Clicked_NextPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("NextPage");
    }
}

