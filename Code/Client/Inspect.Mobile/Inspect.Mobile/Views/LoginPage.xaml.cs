using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.Mobile.Views
{
    public interface ILoginPage :IPageView
    {
        LoginViewModel ViewModel { get; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage, ILoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
            StamNumber.Completed += (s, e) =>
            {
                LoginButton.Command.Execute(null);
            };
            BadgeNumber.Completed += (s, e) =>
             {
                 LoginButton.Command.Execute(null);
             };
        }

        public LoginViewModel ViewModel{

            get { return this.GetViewModelFromResources<LoginViewModel>(); }
        }
    }
}