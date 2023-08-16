using Newtonsoft.Json;

namespace Model.CdsHooks.v1
{
    /// <summary>
    /// The Card class represents a Card object.
    /// https://cds-hooks.hl7.org/1.0/#card-attributes
    /// </summary>
    public class Card
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string? Detail { get; set; }

        [JsonProperty("indicator", NullValueHandling = NullValueHandling.Ignore)]
        public string Indicator { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Suggestion>? Suggestions { get; set; }

        [JsonProperty("selectionBehavior", NullValueHandling = NullValueHandling.Ignore)]
        public string? selectionBehavior { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link>? Links { get; set; }
    }

    /// <summary>
    /// The Source class represents a Source object.
    /// https://cds-hooks.hl7.org/1.0/#source
    /// </summary>
    public class Source
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; }

        public Source(string label, string? url, string? icon)
        {
            Label = label;
            Url = url;
            Icon = icon;
        }
        public Source(string label)
        {
            Label = label;
        }
    }

    /// <summary>
    /// The Suggestion class represents a Suggestion object.
    /// https://cds-hooks.hl7.org/1.0/#suggestion
    /// </summary>
    public class Suggestion
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string? UUID { get; set; }

        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Action>? Actions { get; set; }

        public Suggestion(string label, string? uuid, List<Action>? actions)
        {
            Label = label;
            UUID = uuid;
            Actions = actions;
        }

        public Suggestion(string label)
        {
            Label = label;
        }
    }

    /// <summary>
    /// The Action class represents a Action object.
    /// https://cds-hooks.hl7.org/1.0/#action
    /// </summary>
    public class Action
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public object? Resource { get; set; }

        public Action(string type, string description, object? resource)
        {
            Type = type;
            Description = description;
            Resource = resource;
        }

        public Action(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }

    /// <summary>
    /// The Link class represents a Link object.
    /// https://cds-hooks.hl7.org/1.0/#link
    /// </summary>
    public class Link
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("appContext", NullValueHandling = NullValueHandling.Ignore)]
        public string? AppContext { get; set; }

        public Link(string label, string url, string type, string? appContext)
        {
            Label = label;
            Url = url;
            Type = type;
            AppContext = appContext;
        }

        public Link(string label, string url, string type)
        {
            Label = label;
            Url = url;
            Type = type;
        }
    }
}