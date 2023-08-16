using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    /// <summary>
    /// The CdsService class represents a CdsService object.
    /// https://cds-hooks.hl7.org/1.0/#response
    /// </summary>
    public class CdsService
    {
        [JsonProperty("hook")]
        public string Hook { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
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