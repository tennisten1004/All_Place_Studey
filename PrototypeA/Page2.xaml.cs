namespace PrototypeA;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    private async void NavigateToGameXO(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageXO());
    }
    private async void NavigateToMusic(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageMusic());
    }

}