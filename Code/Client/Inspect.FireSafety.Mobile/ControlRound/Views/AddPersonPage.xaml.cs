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
    public interface IAddPersonPage : IPageView
    {
        AddPersonViewModel ViewModel { get; }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPersonPage : ContentPage, IAddPersonPage
    {
        public AddPersonPage()
        {
            InitializeComponent();
            StamNumber.Completed += (s, e) =>
            {
                LoginButton.Command.Execute(null);
            };
        }

        public AddPersonViewModel ViewModel
        {
            get { return this.GetViewModelFromResources<AddPersonViewModel>(); }
        }
    }
}