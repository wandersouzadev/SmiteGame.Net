using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    public class GetLeagueSeasons
    {
        [JsonPropertyName("complete")]
        public bool Complete { get; private set; }

        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("league_description")]
        public string? LeagueDescription { get; private set; }

        [JsonPropertyName("name")]
        public string? Name { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }

        [JsonPropertyName("round")]
        public int Round { get; private set; }

        [JsonPropertyName("season")]
        public int Season { get; private set; }
    }
}
