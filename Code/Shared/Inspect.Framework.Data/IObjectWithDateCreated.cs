using System;

namespace Inspect.Framework.Data
{
    public interface IObjectWithDateCreated
    {
        DateTimeOffset? DateCreated { get; set; }
    }
}