namespace FruitBazzar;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
        
	}

    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        // ???????????
        // ????????????????

        // ???????????????
        await Navigation.PushAsync(new Home());
    }
}