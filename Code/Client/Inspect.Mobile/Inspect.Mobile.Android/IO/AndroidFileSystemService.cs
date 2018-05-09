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
using Inspect.Mobile.Droid.IO;
using Inspect.Mobile.Framework.Xamarin.IO;


[assembly: Xamarin.Forms.Dependency(typeof(AndroidFileSystemService))]

namespace Inspect.Mobile.Droid.IO
{    
    public class AndroidFileSystemService : IFileSystemService
    {
        public void DeleteDirectory(string path)
        {
            System.IO.Directory.Delete(path);
        }

        public void CreateDirectory(string path)
        {
            System.IO.Directory.CreateDirectory(path);
        }

        public void DeleteFile(string path)
        {
            System.IO.File.Delete(path);
        }

        public bool DirectoryExists(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        public bool FileExists(string path)
        {
            return System.IO.File.Exists(path);
        }

        public Stream OpenRead(string path)
        {
            return System.IO.File.OpenRead(path);
        }

        public Stream OpenWrite(string path, bool overwrite = true)
        {
            if (overwrite) return File.Create(path);
            else  return System.IO.File.OpenWrite(path);
        }

        public IFileInfo GetFileInfo(string fileName)
        {
            return new FileInfoEx(fileName);
        }
    }
}