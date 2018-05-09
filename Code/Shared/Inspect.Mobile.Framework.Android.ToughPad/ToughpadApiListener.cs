using Com.Panasonic.Toughpad.Android.Api;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Android.ToughPad
{
    internal class ToughpadApiListener : Java.Lang.Object, IToughpadApiListener
    {
        private TaskCompletionSource<int> mApiConnectedCompletionSource = new TaskCompletionSource<int>();

        private TaskCompletionSource<object> mApiDisconnectedCompletionSource = new TaskCompletionSource<object>();

        public ToughpadApiListener()
        {
        }

        public async Task<int> ConnectAsync()
        {
            return await mApiConnectedCompletionSource.Task;
        }

        public async Task DisconnectAsync()
        {
            await mApiDisconnectedCompletionSource.Task;
        }

        public void OnApiConnected(int serverVersion)
        {
            mApiConnectedCompletionSource.TrySetResult(serverVersion);
        }

        public void OnApiDisconnected()
        {
            mApiDisconnectedCompletionSource.TrySetResult(null);
        }
    }
}