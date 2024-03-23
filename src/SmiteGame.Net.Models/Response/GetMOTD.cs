using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Returns information about the 20 most recent Match-of-the-Days.
    /// </summary>
    public class GetMOTD
    {
        [JsonPropertyName("description")]
        public string? Description { get; private set; }

        [JsonPropertyName("gameMode")]
        public string? GameMode { get; private set; }

        [JsonPropertyName("maxPlayers")]
        public string? MaxPlayers { get; private set; }

        [JsonPropertyName("name")]
        public string? Name { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }

        [JsonPropertyName("startDateTime")]
        public string? StartDateTime { get; private set; }

        [JsonPropertyName("team1GodsCSV")]
        public string? Team1GodsCSV { get; private set; }

        [JsonPropertyName("team2GodsCSV")]
        public string? Team2GodsCSV { get; private set; }

        [JsonPropertyName("title")]
        public string? Title { get; private set; }
    }

}