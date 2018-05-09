namespace Inspect.Framework.Data
{
    public interface IObjectWithVersion
    {
        byte[] Version { get; set; }
    }
}