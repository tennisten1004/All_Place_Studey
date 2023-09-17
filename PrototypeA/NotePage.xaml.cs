namespace PrototypeA;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
        WebView.Source = new Uri("https://www.rapidtables.com/tools/notepad.html"); // Replace with the desired URL
    }
}