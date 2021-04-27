using System.Text.Json.Serialization;

namespace Mushrooms.Core
{
    public class CategoryTheme
    {
        [JsonPropertyName("categories")]
        public string Categories { get; set; }

        [JsonPropertyName("topBar")]
        public string TopBar { get; set; }

    }
}
