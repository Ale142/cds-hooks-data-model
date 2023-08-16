using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    public class CdsResponse
    {
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
    }
}