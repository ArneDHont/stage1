using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inspect.Mobile.Framework.Xamarin.IO;

namespace Inspect.Mobile.Droid.IO
{
    public class FileInfoEx : IFileInfo
    {

        private readonly FileInfo fileInfo;

        public FileInfoEx(string filename)
        {
            fileInfo = new FileInfo(filename);
        }

        public string DirectoryName
        {
            get { return fileInfo.DirectoryName; }
        }

        public bool IsReadOnly
        {
            get { return fileInfo.IsReadOnly; }
        }

        public long Length
        {
            get { return fileInfo.Length; }
        }

        public DateTime CreationTime
        {
            get { return fileInfo.CreationTime; }
        }

        public bool Exists
        {
            get { return fileInfo.Exists; }
        }

        public string Extension
        {
            get { return fileInfo.Extension; }
        }

        public string FullName
        {
            get { return fileInfo.FullName; }
        }

        public DateTime LastAccessTime
        {
            get { return fileInfo.LastAccessTime; }
        }

        public DateTime LastWriteTime
        {
            get { return fileInfo.LastWriteTime; }
        }

        public string Name
        {
            get { return fileInfo.Name; }
        }
    }
}