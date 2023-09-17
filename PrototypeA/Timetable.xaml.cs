namespace PrototypeA;

public partial class Timetable : ContentPage
{
	public Timetable()
	{
		InitializeComponent();
        WebView.Source = new Uri("https://gizmoa.com/college-schedule-maker/"); // Replace with the desired URL
    }
}