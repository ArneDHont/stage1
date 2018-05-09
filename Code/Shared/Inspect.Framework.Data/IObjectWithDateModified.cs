using System;

namespace Inspect.Framework.Data
{
    public interface IObjectWithDateModified
    {
        DateTimeOffset? DateModified { get; set; }
    }
}