using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Configuration;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using Inspect.Mobile.Framework.Xamarin.Configuration;
using Inspect.Mobile.Framework.Xamarin.IO;
using Inspect.Mobile.Framework.Xamarin.Logging;
using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Inspect.Mobile.Views;
using System;
using System.Net.Http;
using Unity;
using Xamarin.Forms;

namespace Inspect.Mobile
{
    public partial class App : Application, IApplication, IHandle<UnhandledExecptionMessage>
    {
        private IUnityContainer container;

        public IMessenger Messenger
        {
            get
            {
                return Framework.Xamarin.Mvvm.Messenger.Default;
            }
        }

        public App()
        {
            InitializeComponent();

            container = new UnityContainer();

            //Register messenger to container;
            container.RegisterInstance(Messenger);
            Messenger.Subscribe(this);

            // Configure fileSystemService
            var fileSystemService = DependencyService.Get<IFileSystemService>();
            container.RegisterInstance<IFileSystemService>(fileSystemService);

            // Configure logging
            LogManager.SetProvider(() => DependencyService.Get<ILogManagerProvider>());

            // Configure ConfigurationService
            var configurationService = new ResourceConfigurationService();
            container.RegisterInstance<IConfigurationService>(configurationService);

            // Configure WebApiClient
            var httpClient = new HttpClient();
            var webApiClient = new WebApiClient(configurationService.Read<ApiConfiguration>().Root, httpClient);
            container.RegisterInstance<IWebApiClient>(webApiClient);

            // Configure MainPage as a NavigationPage
            var navigationPage = new NavigationPage(new LoginPage());
            navigationPage.Popped += async (sender, e) =>
            {
                var page = e.Page;
                if (page.BindingContext is IPoppedAware aware)
                {
                    await aware.PoppedAsync();
                }
            };
            navigationPage.Pushed += async (sender, e) =>
            {
                var page = e.Page;
                if (page.BindingContext is IPushedAware aware)
                {
                    await aware.PushedAsync();
                }
            };
            MainPage = navigationPage;
            container.RegisterInstance(MainPage.Navigation);
            container.RegisterInstance<IPageResolver>(new ContainerBasedPageResolver(container));

            //Configure message-based ServiceProvider
            var serviceProvider = container.Resolve<ContainerBasedServiceProvider>();
            container.Resolve<IMessenger>().Subscribe(serviceProvider);
            container.RegisterInstance<IServiceProvider>(serviceProvider);

            //Configure message-based Navigation
            var navigateCommandHandler = container.Resolve<NavigationCommandHandler>();
            container.Resolve<IMessenger>().Subscribe(navigateCommandHandler);
            container.RegisterInstance(navigateCommandHandler);

            //Configure BarcodeScannerService
            var barcodeScannerService = DependencyService.Get<IBarcodeScannerService>();
            container.RegisterInstance(barcodeScannerService);

            Startup.ConfigureContainer(container);

        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void Handle(UnhandledExecptionMessage message)
        {
            LogManager.GetLogger(typeof(App)).ExceptionOccured(message.Exception);
        }
    }

    public interface IApplication
    {
        IMessenger Messenger { get; }
    }
}