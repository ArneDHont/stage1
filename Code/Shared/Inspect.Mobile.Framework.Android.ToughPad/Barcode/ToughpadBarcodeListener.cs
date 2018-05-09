using Com.Panasonic.Toughpad.Android.Api.Barcode;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Android.Toughpad.Barcode
{
    internal class ToughpadBarcodeListener : Java.Lang.Object, IBarcodeListener
    {
        private TaskCompletionSource<BarcodeData> mReadCompletionSource = new TaskCompletionSource<BarcodeData>();

        public void OnRead(IBarcodeReader reader, BarcodeData result)
        {
            mReadCompletionSource.TrySetResult(result);
        }

        public Task<BarcodeData> ReadAsync(CancellationToken cancellationToken)
        {
            cancellationToken.Register(s => ((TaskCompletionSource<BarcodeData>)s).SetResult(null), mReadCompletionSource);
            return mReadCompletionSource.Task;
        }
    }
}