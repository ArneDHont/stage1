using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;

namespace Inspect.Mobile.Droid
{
    [Activity(Label = "Fire Safety", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.ArcelorMittal.Light.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            var intent = new Intent(Application.Context, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}