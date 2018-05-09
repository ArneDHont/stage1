using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.FireSafety.Mobile.ControlRound.Views
{

    public interface IWelcomePage : IPageView
    {
        WelcomeViewModel ViewModel { get; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage : ContentPage,IWelcomePage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        public WelcomeViewModel ViewModel
        {
            get
            {
                return this.GetViewModelFromResources<WelcomeViewModel>();
            }
        }
        protected override bool OnBackButtonPressed()
        {            
            return true;
        }
    }
}