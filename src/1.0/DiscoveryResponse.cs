using System.Text.Json.Serialization;

namespace v1_0
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("services")]
        public List<CdsService> Services { get; set; }

        [JsonConstructor]
        public DiscoveryResponse()
        {

        }

        public DiscoveryResponse(List<CdsService> services)
        {
            Services = services;
        }
    }
}