using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace PrototypeA.Pages.Activity.MusicPages;

public partial class Page1Music : ContentPage
{
    public Page1Music()
    {
        InitializeComponent();
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        mediaElement.Stop();
    }

}