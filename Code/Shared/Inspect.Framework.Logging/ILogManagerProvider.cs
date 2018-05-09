using System;

namespace Inspect.Framework.Logging
{
    public interface ILogManagerProvider
    {
        void Configure();

        ILogger GetLogger(Type type);

        ILogger GetLogger(string name);
    }
}