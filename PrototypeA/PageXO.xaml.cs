namespace PrototypeA;

public partial class PageXO : ContentPage
{
	public PageXO()
	{
		InitializeComponent();
        MyWebView.Source = new Uri("https://playtictactoe.org"); // Replace with the desired URL
    }
}