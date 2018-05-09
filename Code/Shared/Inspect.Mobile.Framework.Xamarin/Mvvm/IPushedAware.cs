using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    public interface IPushedAware
    {
        Task PushedAsync();
        
    }
}
