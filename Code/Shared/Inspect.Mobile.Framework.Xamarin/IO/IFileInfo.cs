using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Mobile.Framework.Xamarin.IO
{
    public interface IFileInfo : IFileSystemInfo
    {
        string DirectoryName { get; }
        bool IsReadOnly { get; }
        long Length { get; }
    }
}
