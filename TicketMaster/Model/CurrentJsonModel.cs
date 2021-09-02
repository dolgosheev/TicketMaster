using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TicketMaster.Model
{
    internal class CurrentJsonModel
    {
        [JsonPropertyName("_embedded")]
        public Dictionary<string, List<Entity>> Embedded { get; set; } = new Dictionary<string, List<Entity>>();

        [JsonPropertyName("_links")]
        public Dictionary<string, Dictionary<string, string>> Links { get; set; } =  new Dictionary<string, Dictionary<string, string>>();

        [JsonPropertyName("page")]
        public Dictionary<string, long> Page { get; set; } = new Dictionary<string, long>();
    }

    internal class Entity
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;


        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("test")]
        public bool Test { get; set; } = false;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("locale")] 
        public string Locale { get; set; } = string.Empty;

        /* and more ...*/

    }
}
