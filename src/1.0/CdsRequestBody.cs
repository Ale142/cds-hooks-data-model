
using System.Text.Json.Serialization;

namespace v1_0
{
    public class CdsRequestBody
    {
        [JsonPropertyName("hook")]
        public string Hook { get; set; }

        [JsonPropertyName("hookInstance")]
        public string HookInstance { get; set; }

        [JsonPropertyName("fhirServer"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FhirServer { get; set; }

        [JsonPropertyName("fhirAuthorization"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FhirAuthorizationOptions? FhirAuthorization { get; set; }

        [JsonPropertyName("context")]
        public object Context { get; set; }

        [JsonPropertyName("prefetch"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Prefetch { get; set; }
    }

    public class FhirAuthorizationOptions
    {
        [JsonPropertyName("access_token")]
        public string acces_token { get; set; }

        [JsonPropertyName("token_type")]
        public string token_type { get; set; }

        [JsonPropertyName("expires_in")]
        public int expires_in { get; set; }

        [JsonPropertyName("scope")]
        public string scope { get; set; }

        [JsonPropertyName("subject")]
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