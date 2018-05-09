namespace Inspect.Framework.Hypermedia
{
    public interface IContentResponse<TContent> : IWebApiResponse
    {
        TContent Content { get; }
    }
}