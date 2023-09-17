using System.Globalization;
using System;
using Microsoft.Maui.Controls;

namespace PrototypeA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Get the current time in Thailand
                TimeZoneInfo thaiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Bangkok");
                DateTime thaiTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, thaiTimeZone);

                // Format the time and update the label
                TimeLabel.Text = thaiTime.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);

                // Continue updating the time label
                return true;
            });
        }
        private async void NavigateToPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void NavigateToPage3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void NavigateToPage4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}