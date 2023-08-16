using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    /// <summary>
    ///  The CdsResponse class represents a response object that contains a list of Card objects.
    ///  https://cds-hooks.hl7.org/1.0/#http-response
    /// </summary>
    public class CdsResponse
    {
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
    }
}