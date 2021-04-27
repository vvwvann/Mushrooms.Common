using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mushrooms.Core.Extensions
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PutAsync(this HttpClient client, string url, object data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            return client.PutAsync(url, content);
        }

        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, string url, object data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            return client.PostAsync(url, content);
        }
    }
}
