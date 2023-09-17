using CommunityToolkit.Maui.Views;

namespace PrototypeA.Pages.Activity.MusicPages;

public partial class Page2Music : ContentPage
{
	public Page2Music()
	{
		InitializeComponent();
	}
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        mediaElement.Stop();
    }
}