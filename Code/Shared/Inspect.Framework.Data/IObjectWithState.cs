using System.Collections.Generic;

namespace Inspect.Framework.Data
{
    public interface IObjectWithState
    {
        IDictionary<string, object> OriginalValues { get; set; }

        ObjectState State { get; set; }
    }
}