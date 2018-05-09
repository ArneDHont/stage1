using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Barcode
{
    public interface IBarcodeScannerService
    {
        Task<IBarcodeScanner> GetDefaultAsync();

        Task<IBarcodeScanner> FromIdAsync(string deviceId);

        Task<IList<IBarcodeScanner>> FindAllAsync();
    }
}