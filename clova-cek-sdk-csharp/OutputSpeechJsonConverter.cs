using ClovaCEKCsharp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace ClovaCEKCsharp
{
    /// <summary>
    /// Converter to handle single object or array for same field.
    /// </summary>
    public class OutputSpeechJsonConverter : JsonConverter<OutputSpeech>
    {
        public override void WriteJson(JsonWriter writer, OutputSpeech value, JsonSerializer serializer)
        {
            JObject token = new JObject();
            token["type"] = JToken.FromObject(value.Type);
            token["values"] = value.Values.Count == 1 ? JToken.FromObject(value.Values.First()) : JToken.FromObject(value.Values);
            if (value.Brief != null)
                token["brief"] = JToken.FromObject(value.Brief);
            if (value.Verbose != null)
            {
                token["verbose"] = new JObject();
                token["verbose"]["type"]= JToken.FromObject(value.Verbose.Type);
                token["verbose"]["values"] = value.Verbose.Values.Count == 1 ? JToken.FromObject(value.Verbose.Values.First()) : JToken.FromObject(value.Verbose.Values);
            }
            token.WriteTo(writer);
        }

        public override OutputSpeech ReadJson(JsonReader reader, Type objectType, OutputSpeech existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new OutputSpeech();
        }
    }
}


