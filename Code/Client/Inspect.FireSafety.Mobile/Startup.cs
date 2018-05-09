using Inspect.FireSafety.Mobile.ControlRound.Views;
using Unity;

namespace Inspect.FireSafety.Mobile
{
    public static class Startup
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IEquipmentHistoryPage, EquipmentHistoryPage>();
            container.RegisterType<IControlFormPage, ControlFormPage>();
            container.RegisterType<IControlOverviewPage, ControlOverviewPage>();
            container.RegisterType<IEquipmentDetailPage, EquipmentDetailPage>();
            container.RegisterType<INotOkPage, NotOkPage>();
            container.RegisterType<IPictureViewPage, PictureViewPage>();
            container.RegisterType<IAddPersonPage, AddPersonPage>();
            container.RegisterType<IWelcomePage, WelcomePage>();
        }
    }
}
