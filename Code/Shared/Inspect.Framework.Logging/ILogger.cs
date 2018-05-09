namespace Inspect.Framework.Logging
{
    public interface ILogger
    {
        void Log(ILogEvent logEvent);
    }
}