using System.Text.Json.Serialization;

namespace v1_0
{
    public class CdsService
    {
        [JsonPropertyName("hook")]
        public string Hook { get; set; }

        [JsonPropertyName("title"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("prefetch"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Prefetch { get; set; }

        [JsonConstructor]
        public CdsService()
        {

        }

        public CdsService(string hook, string title, string description, string id, object? prefetch)
        {
            Hook = hook;
            Title = title;
            Description = description;
            Id = id;
            Prefetch = prefetch;
        }

        public CdsService(string hook, string description, string id)
        {
            Hook = hook;
            Description = description;
            Id = id;
        }
    }
}