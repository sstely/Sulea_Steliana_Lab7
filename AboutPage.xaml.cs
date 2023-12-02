namespace Sulea_Steliana_Lab7;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void OnLinkClicked(object sender, EventArgs e)
    {
        string youtubeUrl = "https://www.youtube.com/@ATEEZofficial";
        await Launcher.OpenAsync(new Uri(youtubeUrl));
    }
}
