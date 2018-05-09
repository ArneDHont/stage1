using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Plugin.Media;
using FFImageLoading.Forms.Droid;
using Inspect.Mobile.Framework.Xamarin;
using Inspect.Mobile.Framework.Android.Toughpad.Barcode;
using Xamarin.Forms.Platform.Android;
using System.Threading;
using System.Threading.Tasks;
using Inspect.Mobile.Droid.Configuration;

using System;

using Java.Lang;
using Java.IO;


[assembly: Xamarin.Forms.Dependency(typeof(ToughpadBarcodeScannerService))]
namespace Inspect.Mobile.Droid
{
    [Activity(Label = "Fire Safety", Theme = "@style/Theme.ArcelorMittal.Light", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public void CloseApplication()
        {
            this.FinishAffinity();
        }

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);



            File appDirectory = GetExternalFilesDir(null);
            File logDirectory = new File(appDirectory + "/log");
            File logFile = new File(logDirectory + "/BBW_Inspect.Mobile_Logging_"+ DateTime.Now.ToString("yyyyMMddHHmmss")+".txt");
            if (!logDirectory.Exists()) logDirectory.Mkdir();

            Java.Lang.Process process = Runtime.GetRuntime().Exec("logcat -c");
            process = Runtime.GetRuntime().Exec("logcat -f " + logFile +" -v time");

            AndroidEnvironment.UnhandledExceptionRaiser += AndroidEnvironment_UnhandledExceptionRaiser;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            Xamarin.Forms.Forms.Init(this, bundle);

            var app = new App();
            // Register the third-party plugins
            PluginConfig.Register(app, this, bundle);
            LoadApplication(new App());
        }
        private void AndroidEnvironment_UnhandledExceptionRaiser(object sender, RaiseThrowableEventArgs e)
        {
            Framework.Xamarin.Mvvm.Messenger.Default.PublishOnCurrentThread(new UnhandledExecptionMessage(e.Exception));
        }
    }
}