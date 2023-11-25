using Xamarin.Essentials;
using Launcher = Xamarin.Essentials.Launcher;

namespace Sulea_Steliana_Lab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnLinkClicked(object sender, EventArgs e)
        {
            string youtubeUrl = "https://www.youtube.com/@ATEEZofficial";
            await Launcher.OpenAsync(new Uri(youtubeUrl));
        }
    }
}