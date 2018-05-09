using System.Net;
using System.Text;

namespace Inspect.Framework.Hypermedia
{
    public class WebApiResponse : IWebApiResponse
    {
        public WebApiResponse(HttpStatusCode statusCode, string reasonPhrase)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
        }

        public bool IsSuccessStatusCode
        {
            get { return ((int)StatusCode >= 200) && ((int)StatusCode <= 299); }
        }

        public string ReasonPhrase { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public static IWebApiResponse Create(HttpStatusCode statusCode, string reasonPhrase)
        {
            return new WebApiResponse(statusCode, reasonPhrase);
        }

        public static IWebApiResponse Create<TContent>(HttpStatusCode statusCode, string reasonPhrase, TContent content)
        {
            return new ContentWebApiResponse<TContent>(statusCode, reasonPhrase, content);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{(int)StatusCode} - {ReasonPhrase}");
            return builder.ToString().TrimEnd();
        }
    }
}