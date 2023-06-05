using System.Text.Json.Serialization;

namespace v1_0
{
    public class Card
    {
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("detail"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Detail { get; set; }

        [JsonPropertyName("indicator"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Indicator { get; set; }

        [JsonPropertyName("source")]
        public Source Source { get; set; }

        [JsonPropertyName("suggestions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Suggestion>? Suggestions { get; set; }

        [JsonPropertyName("selectionBehavior"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? selectionBehavior { get; set; }

        [JsonPropertyName("links"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Link>? Links { get; set; }
    }

    public class Source
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("url"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Url { get; set; }

        [JsonPropertyName("icon"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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

    public class Suggestion
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("uuid"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UUID { get; set; }

        [JsonPropertyName("actions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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

    public class Action
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("resource"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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

    public class Link
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("appContext"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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