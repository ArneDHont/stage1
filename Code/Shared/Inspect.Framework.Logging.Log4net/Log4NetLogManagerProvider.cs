using System;

namespace Inspect.Framework.Logging.Log4net
{
    public class Log4NetLogManagerProvider : ILogManagerProvider
    {
        public void Configure()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public ILogger GetLogger(Type type)
        {
            return new Log4NetLogger(log4net.LogManager.GetLogger(type));
        }

        public ILogger GetLogger(string name)
        {
            return new Log4NetLogger(log4net.LogManager.GetLogger(name));

        }
    }
}