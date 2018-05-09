using System.Net;
using System.Text;

namespace Inspect.Framework.Hypermedia
{
    public class ContentWebApiResponse<TContent> : WebApiResponse, IContentResponse<TContent>
    {
        public ContentWebApiResponse(HttpStatusCode statusCode, string reasonPhrase, TContent content) : base(statusCode, reasonPhrase)
        {
            this.Content = content;
        }

        public TContent Content { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{(int)StatusCode} - {ReasonPhrase}");
            builder.AppendLine(Content?.ToString() ?? string.Empty);
            return builder.ToString().TrimEnd();
        }
    }
}