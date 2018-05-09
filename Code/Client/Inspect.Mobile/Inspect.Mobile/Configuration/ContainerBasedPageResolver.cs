using Inspect.Mobile.Framework.Xamarin.Mvvm;
using System;
using Unity;
using Xamarin.Forms;

namespace Inspect.Mobile.Configuration
{
    public class ContainerBasedPageResolver : IPageResolver
    {
        private IUnityContainer mContainer;

        public ContainerBasedPageResolver(IUnityContainer container)
        {
            mContainer = container ?? throw new ArgumentNullException(nameof(container));
        }

        public Page GetPage<TPageView>() where TPageView : IPageView
        {
            var page = ResolvePage<TPageView>();

            page.SetBinding(NavigationPage.HasNavigationBarProperty, nameof(ViewModelBase.HasNavigationBar));
            page.SetBinding(Page.TitleProperty, nameof(ViewModelBase.Title));
            page.Appearing += async (sender, e) =>
            {
                var p = sender as Page;
                if (p.BindingContext is IAppearingAware aware)
                {
                    await aware.AppearingAsync();
                }
            };
            page.Disappearing += async (sender, e) =>
            {
                var p = sender as Page;
                if (p.BindingContext is IDisappearingAware aware)
                {
                    await aware.DisappearingAsync();
                }
            };
           
            return page;
        }

        private Page ResolvePage<TPageView>() where TPageView : IPageView
        {
            var page = mContainer.Resolve<TPageView>();
            if (!(page is Page))
            {
                throw new Exception($"The container did not return a Page for the specified generic type parameter '{typeof(TPageView).Name}'");
            }
            return page as Page;
        }
    }
}