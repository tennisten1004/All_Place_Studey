using CommunityToolkit.Maui.Views;

namespace PrototypeA.Pages.Activity.MusicPages;

public partial class Page3Music : ContentPage
{
	public Page3Music()
	{
		InitializeComponent();
	}
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        mediaElement.Stop();
    }
}