namespace PrototypeA;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    private async void NavigateToNote(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotePage());
    }
    private async void NavigateToTimetable (object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Timetable());
    }
}