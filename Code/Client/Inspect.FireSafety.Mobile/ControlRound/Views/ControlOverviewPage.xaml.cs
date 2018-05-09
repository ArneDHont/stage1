using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Acr.UserDialogs;

namespace Inspect.FireSafety.Mobile.ControlRound.Views
{

    public interface IControlOverviewPage : IPageView
    {
        ControlOverviewViewModel ViewModel { get; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlOverviewPage : ContentPage, IControlOverviewPage
    {
        private Button oldButton;
        private ControlOverviewViewModel viewModel;
        private bool goBack;
        public ControlOverviewPage()
        {
            InitializeComponent();
            this.ToScan.TextColor = Color.FromHex("FE3700");
            this.ToScan.FontAttributes = FontAttributes.Bold;

            this.scanned.TextColor = Color.Gray;
            this.scanned.FontAttributes = FontAttributes.None;

            this.Ok.TextColor = Color.Gray;
            this.Ok.FontAttributes = FontAttributes.None;

            this.NotOk.TextColor = Color.Gray;
            this.NotOk.FontAttributes = FontAttributes.None;

            oldButton = this.ToScan;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.TextColor = Color.FromHex("FE3700");
            button.FontAttributes = FontAttributes.Bold;
            oldButton.TextColor = Color.Gray;
            oldButton.FontAttributes = FontAttributes.None;
            oldButton = button;
        }
        public ControlOverviewViewModel ViewModel
        {
            get { return this.GetViewModelFromResources<ControlOverviewViewModel>(); }
        }

        protected override bool OnBackButtonPressed()
        {
            ShowDialogAsync();
            return true;
        }

        private async void ShowDialogAsync()
        {
            if (ViewModel.DevicesInspected.Count == 0)
            {
                goBack = await UserDialogs.Instance.ConfirmAsync("Bent u zeker om deze ronde af te sluiten.", "Inspectie annuleren", "Ja", "Neen", null);
                if (goBack)
                {
                    await Navigation.PopAsync();
                }
            }
            else
            {
                UserDialogs.Instance.Alert("Er is al reeds een item geïnspecteerda. U kunt deze ronde niet annuleren", "Inspectie annuleren", "ok");
            }

        }
    }
}