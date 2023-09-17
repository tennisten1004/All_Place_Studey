using PrototypeA.Pages.Activity.MusicPages;
namespace PrototypeA;

public partial class PageMusic : ContentPage
{
	public PageMusic()
	{
		InitializeComponent();
    }
    private async void NavigateTo1Music(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1Music());
    }
    private async void NavigateTo2Music(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2Music());
    }
    private async void NavigateTo3Music(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3Music());
    }

}