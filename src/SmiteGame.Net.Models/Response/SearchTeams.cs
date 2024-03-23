using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Returns high level information for Clan names containing the “searchTeam” string.
    /// </summary>
    public class SearchTeams
    {
        [JsonPropertyName("Founder")]
        public string? Founder { get; private set; }

        [JsonPropertyName("Name")]
        public string? Name { get; private set; }

        [JsonPropertyName("Players")]
        public int Players { get; private set; }

        [JsonPropertyName("Tag")]
        public string? Tag { get; private set; }

        [JsonPropertyName("TeamId")]
        public int TeamId { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}