using Newtonsoft.Json.Serialization;
using System;

namespace Inspect.Framework.Hypermedia.Json
{
    public class KebabCasePropertyNamesContractResolver : IContractResolver
    {
        private static readonly DefaultContractResolver sResolver = new DefaultContractResolver() { NamingStrategy = new KebabCaseNamingStrategy() };

        public JsonContract ResolveContract(Type type)
        {
            return sResolver.ResolveContract(type);
        }
    }
}