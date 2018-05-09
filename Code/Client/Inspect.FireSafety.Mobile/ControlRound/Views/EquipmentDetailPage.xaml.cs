using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Inspect.FireSafety.Mobile.ControlRound.Models;
using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.FireSafety.Mobile.ControlRound.Views
{
    public interface IEquipmentDetailPage : IPageView
    {
        EquipmentDetailViewModel ViewModel { get; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EquipmentDetailPage : ContentPage , IEquipmentDetailPage
	{
        
        public EquipmentDetailPage ()
		{
            
			InitializeComponent ();
            
        }

        public EquipmentDetailViewModel ViewModel {
            get
            {
                return this.GetViewModelFromResources<EquipmentDetailViewModel>();
            }
        }
    }
}