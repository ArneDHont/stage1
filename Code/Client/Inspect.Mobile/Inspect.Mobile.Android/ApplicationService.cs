using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inspect.Mobile.Droid;
using Inspect.Mobile.Framework.Xamarin;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(ApplicationService))]

namespace Inspect.Mobile.Droid
{
    
    public class ApplicationService : IApplicationService
    {
        public void CloseApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}