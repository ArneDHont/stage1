using Android.Content;
using Com.Panasonic.Toughpad.Android.Api;
using Com.Panasonic.Toughpad.Android.Api.Barcode;
using Inspect.Mobile.Framework.Android.ToughPad;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Android.Toughpad.Barcode
{
    public class ToughpadBarcodeScannerService : IBarcodeScannerService
    {
        private Context mContext;

        public ToughpadBarcodeScannerService()
        {
            mContext = global::Android.App.Application.Context;
        }

        public Task<int> ConnectAsync()
        {
            if (!ToughpadApi.IsAlreadyInitialized)
            {
                var apiListener = new ToughpadApiListener();
                ToughpadApi.Initialize(mContext, apiListener);
                return apiListener.ConnectAsync();
            }
            else
            {
                return Task.FromResult(ToughpadApi.ServerVersion);
            }
        }

        public Task<IList<IBarcodeScanner>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IBarcodeScanner> FromIdAsync(string deviceId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IBarcodeScanner> GetDefaultAsync()
        {
            await ConnectAsync();

            var barcodeReader = BarcodeReaderManager.BarcodeReaders.FirstOrDefault();
            if (barcodeReader == null)
            {
                return null;
            }
            else
            {
                return new ToughpadBarcodeScanner(barcodeReader);
            }
        }
    }
}