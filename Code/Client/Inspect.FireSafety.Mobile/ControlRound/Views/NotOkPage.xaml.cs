using Acr.UserDialogs;
using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.FireSafety.Mobile.ControlRound.Views


{
    public interface INotOkPage : IPageView
    {
        NotOkViewModel ViewModel { get; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotOkPage : ContentPage, INotOkPage
    {

        public NotOkPage(Models.EquipmentModel detail)
        {
            InitializeComponent();            
        }        
        public NotOkViewModel ViewModel
        {
            get
            {
                return this.GetViewModelFromResources<NotOkViewModel>();
            }

        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}