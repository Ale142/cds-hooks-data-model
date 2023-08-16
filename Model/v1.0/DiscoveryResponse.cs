using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    /// <summary>
    /// The DiscoveryResponse class represents a DiscoveryResponse object that the server
    /// shall use when the CDS client invoke the discovery endpoint (usually: https://example.com/cds-services).
    /// https://cds-hooks.hl7.org/1.0/#response
    /// </summary>
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