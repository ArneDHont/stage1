using Acr.UserDialogs;
using Android.App;
using Android.OS;
using FFImageLoading.Forms.Droid;
using Plugin.Media;
using System.Threading.Tasks;

namespace Inspect.Mobile.Droid.Configuration
{
    public static class PluginConfig
    {
        public static void Register(IApplication application, Activity context, Bundle bundle)
        {
            UserDialogs.Init(context);
            CachedImageRenderer.Init(true);
            Task.Run(() => CrossMedia.Current.Initialize());
        }
    }
}