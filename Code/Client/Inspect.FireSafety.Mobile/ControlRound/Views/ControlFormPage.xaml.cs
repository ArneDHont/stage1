using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;

namespace Inspect.FireSafety.Mobile.ControlRound.Views

{
    public interface IControlFormPage : IPageView
    {
        ControlFormViewModel ViewModel { get; }
    }


	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlFormPage : ContentPage, IControlFormPage
	{
        

        public ControlFormPage ()
		{
			InitializeComponent ();
            this.Datepicker.MaximumDate = DateTime.Now.Date;
           
		}

        public ControlFormViewModel ViewModel
        {
            get { return this.GetViewModelFromResources<ControlFormViewModel>(); }
        }

        
    }
}