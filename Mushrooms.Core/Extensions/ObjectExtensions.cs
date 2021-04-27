using System.Text.Json;

namespace Mushrooms.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToJsonString(this object json, 
            JsonSerializerOptions options = null)
        {
            options ??= new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            return JsonSerializer.Serialize(json, options);
        }

        public static bool EqualsJson(this object json, object other)
        {
            string first = json.ToJsonString();
            string second = other.ToJsonString();

            return first == second;
        }

        public static JsonDocument ToJsonDocument(this object json,
           JsonSerializerOptions options = null)
        {
            options ??= new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            return JsonDocument.Parse(JsonSerializer.Serialize(json, options));
        }
    }
}