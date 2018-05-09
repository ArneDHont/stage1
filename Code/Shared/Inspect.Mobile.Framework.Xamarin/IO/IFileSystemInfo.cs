using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Mobile.Framework.Xamarin.IO
{
    public interface IFileSystemInfo
    {
        DateTime CreationTime { get; }
        bool Exists { get; }
        string Extension { get; }
        string FullName { get; }
        DateTime LastAccessTime { get; }
        DateTime LastWriteTime { get; }

        string Name { get; }

    }
}
