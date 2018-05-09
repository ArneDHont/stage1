using System;

namespace Bbw.Inspect.Framework.Data
{
    public interface IObjectWithDateDeleted
    {
        DateTimeOffset? DateDeleted { get; set; }
    }
}