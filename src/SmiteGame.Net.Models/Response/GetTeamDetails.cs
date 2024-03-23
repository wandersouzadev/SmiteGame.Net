using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Lists the number of players and other high level details for a particular clan.
    /// </summary>
    public class GetTeamDetails
    {
        [JsonPropertyName("Founder")]
        public string? Founder { get; private set; }

        [JsonPropertyName("FounderId")]
        public string? FounderId { get; private set; }

        [JsonPropertyName("Losses")]
        public int Losses { get; private set; }

        [JsonPropertyName("Name")]
        public string? Name { get; private set; }

        [JsonPropertyName("Players")]
        public int Players { get; private set; }

        [JsonPropertyName("Rating")]
        public int Rating { get; private set; }

        [JsonPropertyName("Tag")]
        public string? Tag { get; private set; }

        [JsonPropertyName("TeamId")]
        public int TeamId { get; private set; }

        [JsonPropertyName("Wins")]
        public int Wins { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}