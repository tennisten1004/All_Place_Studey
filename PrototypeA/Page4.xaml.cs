namespace PrototypeA;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}
    private async void NavigateToMath(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MathPage());
    }
    private async void NavigateToBio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BioPage());
    }
    private async void NavigateToChem(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChemPage());
    }
    private async void NavigateToPhy(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhyPage());
    }
}