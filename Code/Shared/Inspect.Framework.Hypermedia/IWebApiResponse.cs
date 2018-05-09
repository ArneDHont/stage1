using System;
using System.Net;

namespace Inspect.Framework.Hypermedia
{
    public interface IWebApiResponse
    {
        bool IsSuccessStatusCode { get; }

        string ReasonPhrase { get; }

        HttpStatusCode StatusCode { get; }
    }

    public static class WebApiResponseExtensions
    {
        public static TContent EnsureContent<TContent>(this IWebApiResponse response)
        {
            var typedResponse = response as IContentResponse<TContent>;
            if (typedResponse == null || !(typedResponse.Content is TContent))
            {
                throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Representaton_Not_Expected, typedResponse?.Content?.GetType()?.GetFriendlyeName() ?? "null", typeof(TContent).GetFriendlyeName(), response));
            }
            return typedResponse.Content;
        }

        public static HttpStatusCode EnsureStatusCode(this IWebApiResponse response, HttpStatusCode statusCode)
        {
            if (response.StatusCode != statusCode)
            {
                throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Http_Status_Not_Expected, response.StatusCode, response.ReasonPhrase, statusCode));
            }
            return response.StatusCode;
        }

        public static HttpStatusCode EnsureSuccessStatusCode(this IWebApiResponse response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new WebApiException(string.Format(Resources.Strings.WebApiClient_Http_Status_Not_Success, response.StatusCode, response.ReasonPhrase));
            }
            return response.StatusCode;
        }

        private static string GetFriendlyeName(this Type type)
        {
            return type.Name;
            //var codeDomProvider = CodeDomProvider.CreateProvider("C#");
            //var typeReferenceExpression = new CodeTypeReferenceExpression(new CodeTypeReference(type));
            //using (var writer = new StringWriter())
            //{
            //    codeDomProvider.GenerateCodeFromExpression(typeReferenceExpression, writer, new CodeGeneratorOptions());
            //    return writer.GetStringBuilder().ToString();
            //}
        }
    }
}