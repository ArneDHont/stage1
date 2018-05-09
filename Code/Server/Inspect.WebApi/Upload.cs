using System.IO;

namespace Inspect.WebApi
{
    public class Upload<TMetadata>
    {
        public Upload(TMetadata metadata, Stream inputStream)
        {
            Metadata = metadata;
            InputStream = inputStream;
        }

        public Upload()
        {
        }

        public Stream InputStream { get; set; }

        public TMetadata Metadata { get; set; }
    }
}