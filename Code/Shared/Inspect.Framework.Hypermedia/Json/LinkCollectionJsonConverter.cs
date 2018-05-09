using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Inspect.Framework.Hypermedia.Json
{
    public class LinkCollectionJsonConverter : JsonConverter
    {
        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LinkCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var returnValue = (LinkCollection)existingValue ?? new LinkCollection();

            JToken token = JToken.Load(reader);
            foreach (JProperty c in token.Children().OfType<JProperty>())
            {
                if (c.Value.Type == JTokenType.Object)
                {
                    var link = c.Value.ToObject<Link>(serializer);
                    returnValue.Add(c.Name, link);
                }
                else if (c.Value.Type == JTokenType.Array)
                {
                    var linkArray = c.Value.ToObject<Link[]>(serializer);
                    returnValue.AddRange(c.Name, linkArray);
                }
            }
            return returnValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var resourceList = (LinkCollection)value;
            writer.WriteStartObject();

            foreach (NamedRelationEntry<Link> r in resourceList)
            {
                writer.WritePropertyName(r.Name.ToLowerInvariant());

                int count = r.Relations.Count;
                if (count > 1)
                {
                    serializer.Serialize(writer, r.Relations.ToArray(), typeof(Link[]));
                }
                else if (count == 1)
                {
                    serializer.Serialize(writer, r.Relations[0], typeof(Link));
                }
            }
            writer.WriteEndObject();
        }
    }
}