using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Inspect.Framework.Hypermedia.Json
{
    internal class EmbeddedRepresentationCollectionJsonConverter : JsonConverter
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
            return objectType == typeof(EmbeddedRepresentationCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var returnValue = (EmbeddedRepresentationCollection)existingValue ?? new EmbeddedRepresentationCollection();

            JToken token = JToken.Load(reader);
            foreach (JProperty c in token.Children().OfType<JProperty>())
            {
                if (c.Value.Type == JTokenType.Object)
                {
                    var representation = c.Value.ToObject<Representation>(serializer);
                    returnValue.Add(c.Name, representation);
                }
                else if (c.Value.Type == JTokenType.Array)
                {
                    var representationArray = c.Value.ToObject<Representation[]>(serializer);
                    returnValue.AddRange(c.Name, representationArray);
                }
            }
            return returnValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var representationCollection = (EmbeddedRepresentationCollection)value;
            writer.WriteStartObject();

            foreach (NamedRelationEntry<Representation> r in representationCollection)
            {
                int count = r.Relations.Count;

                if (count != 0)
                {
                    writer.WritePropertyName(r.Name.ToLowerInvariant());
                }
                if (count > 1 || r.IsInitializedAsArray)
                {
                    serializer.Serialize(writer, r.Relations.ToArray(), typeof(Representation[]));
                }
                else if (count == 1)
                {
                    serializer.Serialize(writer, r.Relations[0], typeof(Representation));
                }
            }
            writer.WriteEndObject();
        }
    }
}