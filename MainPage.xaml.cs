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
            string youtubeUrl = "https://youtu.be/9t57C7NcjWo?si=pA3f8o0FtPugu9pR";
            await Launcher.OpenAsync(new Uri(youtubeUrl));
        }
    }
}