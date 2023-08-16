
using Newtonsoft.Json;
namespace Model.CdsHooks.v1
{
    public class CdsRequest
    {
        [JsonProperty("hook")]
        public string Hook { get; set; }

        [JsonProperty("hookInstance")]
        public string HookInstance { get; set; }

        [JsonProperty("fhirServer", NullValueHandling = NullValueHandling.Ignore)]
        public string? FhirServer { get; set; }

        [JsonProperty("fhirAuthorization", NullValueHandling = NullValueHandling.Ignore)]
        public FhirAuthorizationOptions? FhirAuthorization { get; set; }

        [JsonProperty("context")]
        public object Context { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public object? Prefetch { get; set; }
    }

    public class FhirAuthorizationOptions
    {
        [JsonProperty("access_token")]
        public string acces_token { get; set; }

        [JsonProperty("token_type")]
        public string token_type { get; set; }

        [JsonProperty("expires_in")]
        public int expires_in { get; set; }

        [JsonProperty("scope")]
        public string scope { get; set; }

        [JsonProperty("subject")]
        public string subject { get; set; }

        public FhirAuthorizationOptions(string acces_token, string token_type, int expires_in, string scope, string subject)
        {
            this.acces_token = acces_token;
            this.token_type = token_type;
            this.expires_in = expires_in;
            this.scope = scope;
            this.subject = subject;
        }
    }
}