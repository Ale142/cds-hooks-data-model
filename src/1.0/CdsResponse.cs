using System.Text.Json.Serialization;

namespace v1_0
{
    public class CdsResponse
    {
        [JsonPropertyName("cards")]
        public List<Card> Cards { get; set; }
    }
}