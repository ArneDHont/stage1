using Inspect.Mobile.Framework.Xamarin.Mvvm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspect.Mobile.Framework.Test
{
    [TestClass]
    public class UnitTest1
    {
        private interface MyView : IPageView
        {
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            Mock<IPageResolver> pageResolverMock = new Mock<IPageResolver>();
            Mock<INavigation> navigationMock = new Mock<INavigation>();

            NavigationCommandHandler handler = new NavigationCommandHandler(navigationMock.Object, pageResolverMock.Object);

            Messenger.Default.Subscribe(handler);
            var message = new NavigationPushMessage<MyView>();
            await Messenger.Default.PublishAsync<INavigationCommand>(message, CancellationToken.None);
        }
    }
}