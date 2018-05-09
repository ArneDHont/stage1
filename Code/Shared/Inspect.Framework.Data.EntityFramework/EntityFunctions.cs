using System;
using System.Data.Entity;

namespace Inspect.Framework.Data
{
    public static class EntityFunctions
    {
        [DbFunction("Edm", "TruncateTime")]
        public static DateTime? TruncateTime(DateTime? dateValue)
        {
            throw new NotImplementedException();
        }
    }
}