using Inspect.Framework.Hypermedia;
using Inspect.Mobile.Framework.Xamarin.ComponentModel;
using System;
using System.Threading;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public class ViewModelBase : ObservableObject, IServiceProvider
    {
        private int mBusyCounter = 0;

        private bool mHasNavigationBar = true;

        private IMessenger mMessengerInstance;

        private INavigationService mNavigationService;

        private IWebApiClient mWebApiClient;

        private string mTitle;

        /// <summary>
        /// Initializes a new instance of the SivekaViewModelBase class.
        /// </summary>
        public ViewModelBase() : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewModelBase class.
        /// </summary>
        /// <param name="messenger">An instance of a <see cref="IMessenger"/>
        /// used to broadcast messages to other objects. If null, this class
        /// will attempt to broadcast using the Messengers's default instance.</param>
        public ViewModelBase(IMessenger messenger = null)
        {
            mMessengerInstance = messenger;
        }

        public IWebApiClient Client
        {
            get
            {
                return mWebApiClient ?? (mWebApiClient = GetService<IWebApiClient>());
            }
            set
            {
                mWebApiClient = value;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether the page has a navigation bar.
        /// </summary>
        public bool HasNavigationBar
        {
            get
            {
                return mHasNavigationBar;
            }
            set
            {
                Set(ref mHasNavigationBar, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the view model is currently busy.
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return mBusyCounter > 0;
            }
            set
            {
                if (value)
                {
                    Interlocked.Increment(ref mBusyCounter);
                }
                else if (mBusyCounter > 0)
                {
                    Interlocked.Decrement(ref mBusyCounter);
                }
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the NavigationService of this ViewModel
        /// </summary>
        public INavigationService NavigationService
        {
            get
            {
                return mNavigationService ?? (mNavigationService = new NavigationService(MessengerInstance));
            }
            set
            {
                mNavigationService = value;
            }
        }

        /// <summary>
        /// Gets or sets the title of the ViewModel.
        /// </summary>
        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                Set(ref mTitle, value);
            }
        }

        /// <summary>
        /// Gets or sets the Messenger correcponding this ViewModel.
        /// </summary>
        protected IMessenger MessengerInstance
        {
            get
            {
                return mMessengerInstance ?? (mMessengerInstance = Messenger.Default);
            }
            set
            {
                mMessengerInstance = value;
            }
        }

        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>A service object of type serviceType.</returns>
        public object GetService(Type serviceType)
        {
            object service = null;
            var message = new ServiceProviderMessage(serviceType, (s) => service = s);
            MessengerInstance.PublishOnCurrentThread<IServiceProviderCommand>(message);
            return service;
        }

        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <returns>A service object of type serviceType.</returns>
        public TType GetService<TType>()
        {
            var instance = GetService(typeof(TType));
            return (TType)instance;
        }
    }
}