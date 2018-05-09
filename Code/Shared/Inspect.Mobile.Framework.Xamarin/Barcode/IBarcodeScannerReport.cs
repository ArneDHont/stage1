using System.Collections.Generic;

namespace Inspect.Mobile.Framework.Xamarin.Barcode
{
    public interface IBarcodeScannerReport
    {
        string ScanDataLabel { get; }

        byte[] ScanData { get; }

        IReadOnlyDictionary<string, object> Properties { get; }
    }
}