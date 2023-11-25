using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Sulea_Steliana_Lab7
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.KeepScreenOn);
            this.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)
                (SystemUiFlags.ImmersiveSticky | SystemUiFlags.HideNavigation | SystemUiFlags.LowProfile |
                SystemUiFlags.Fullscreen | SystemUiFlags.Immersive);
        }
    }
}