using Com.Panasonic.Toughpad.Android.Api.Barcode;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Android.Toughpad.Barcode
{
    internal class ToughpadBarcodeScanner : IBarcodeScanner
    {
        public const long DefaultEnableTimeout = 500;

        private IBarcodeReader mBarcodeReader;

        public ToughpadBarcodeScanner(IBarcodeReader barcodeReader)
        {
            mBarcodeReader = barcodeReader;
        }

        public string DeviceId
        {
            get
            {
                return mBarcodeReader.DeviceName;
            }
        }

        public Task<IReadOnlyDictionary<string, object>> RetrievePropertiesAsync()
        {
            if (!mBarcodeReader.IsEnabled)
            {
                mBarcodeReader.Enable(DefaultEnableTimeout);
            }
            var properties = new Dictionary<string, object>()
            {
                { "Panasonic.Toughpad.Android.Barcode.DeviceFirmwareVersion", mBarcodeReader.DeviceFirmwareVersion },
                { "Panasonic.Toughpad.Android.Barcode.BarcodeType", mBarcodeReader.BarcodeType },
                { "Panasonic.Toughpad.Android.Barcode.DeviceName", mBarcodeReader.DeviceName },
                { "Panasonic.Toughpad.Android.Barcode.DeviceSerialNumber", mBarcodeReader.DeviceSerialNumber },
                { "Panasonic.Toughpad.Android.Barcode.IsExternal", mBarcodeReader.IsExternal },
                { "Panasonic.Toughpad.Android.Barcode.IsHardwareTriggerAvailable", mBarcodeReader.IsHardwareTriggerAvailable },
                { "Panasonic.Toughpad.Android.Barcode.BatteryCharge", mBarcodeReader.BatteryCharge },
                { "Panasonic.Toughpad.Android.Barcode.IsBatteryCharging", mBarcodeReader.IsBatteryCharging }
            };

            if (!mBarcodeReader.IsEnabled)
            {
                mBarcodeReader.Disable();
            }
            return Task.FromResult<IReadOnlyDictionary<string, object>>(properties);
        }

        public async Task<IBarcodeScannerReport> ScanAsync(CancellationToken cancellationToken)
        {
            if (!mBarcodeReader.IsEnabled)
            {
                mBarcodeReader.Enable(DefaultEnableTimeout);
            }

            if (!cancellationToken.IsCancellationRequested)
            {
                var barcodeListener = new ToughpadBarcodeListener();
                try
                {
                    mBarcodeReader.AddBarcodeListener(barcodeListener);
                    mBarcodeReader.PressSoftwareTrigger(true);
                    var data = await barcodeListener.ReadAsync(cancellationToken);
                    return data != null ? new ToughpadBarcodeScannerReport(data) : default(IBarcodeScannerReport);
                }
                finally
                {
                    mBarcodeReader.PressSoftwareTrigger(false);
                    mBarcodeReader.RemoveBarcodeListener(barcodeListener);
                    if (mBarcodeReader.IsEnabled)
                    {
                        mBarcodeReader.Disable();
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}