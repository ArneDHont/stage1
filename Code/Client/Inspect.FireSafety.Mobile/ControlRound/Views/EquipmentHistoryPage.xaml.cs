using Inspect.FireSafety.Mobile.ControlRound.ViewModels;
using Inspect.Mobile.Framework.Xamarin.Mvvm;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspect.FireSafety.Mobile.ControlRound.Views
{
    public interface IEquipmentHistoryPage : IPageView
    {
        EquipmentHistoryViewModel ViewModel { get; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquipmentHistoryPage : ContentPage, IEquipmentHistoryPage
    {
        public EquipmentHistoryPage()
        {
            InitializeComponent();
        }

        public EquipmentHistoryViewModel ViewModel
        {
            get { return this.GetViewModelFromResources<EquipmentHistoryViewModel>(); }
        }
    }
}