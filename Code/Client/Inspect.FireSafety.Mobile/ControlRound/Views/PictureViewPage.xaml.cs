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
    public interface IPictureViewPage : IPageView
    {
        PictureViewViewModel ViewModel { get; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PictureViewPage : ContentPage, IPictureViewPage
    {
        public PictureViewPage()
        {
            InitializeComponent();            
        }

        public PictureViewViewModel ViewModel
        {
            get
            {
                return this.GetViewModelFromResources<PictureViewViewModel>();
            }
        }
    }
}