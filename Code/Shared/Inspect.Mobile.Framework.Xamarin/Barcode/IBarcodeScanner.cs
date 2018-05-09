using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Barcode
{
    public interface IBarcodeScanner
    {
        string DeviceId { get; }

        Task<IReadOnlyDictionary<string, object>> RetrievePropertiesAsync();

        Task<IBarcodeScannerReport> ScanAsync(CancellationToken cancellationToken);
    }
}