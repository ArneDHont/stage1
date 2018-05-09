using Com.Panasonic.Toughpad.Android.Api.Barcode;
using Inspect.Mobile.Framework.Xamarin.Barcode;
using System.Collections.Generic;

namespace Inspect.Mobile.Framework.Android.Toughpad.Barcode
{
    internal class ToughpadBarcodeScannerReport : IBarcodeScannerReport
    {
        private BarcodeData mBarcodeData;

        public ToughpadBarcodeScannerReport(BarcodeData data)
        {
            mBarcodeData = data;
        }

        public IReadOnlyDictionary<string, object> Properties
        {
            get
            {
                return new Dictionary<string, object>()
                {
                    { "Panasonic.Toughpad.Android.Barcode.Encoding", mBarcodeData.Encoding },
                    { "Panasonic.Toughpad.Android.Barcode.Symbology", mBarcodeData.Symbology },
                    { "Panasonic.Toughpad.Android.Barcode.TextData", mBarcodeData.TextData },
                    { "Panasonic.Toughpad.Android.Barcode.BinaryData", mBarcodeData.GetBinaryData() }
                };
            }
        }

        public byte[] ScanData
        {
            get
            {
                return mBarcodeData.GetBinaryData();
            }
        }

        public string ScanDataLabel
        {
            get
            {
                return mBarcodeData.TextData;
            }
        }
    }
}