using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    public class DiscoveryResponse
    {
        [JsonProperty("services")]
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