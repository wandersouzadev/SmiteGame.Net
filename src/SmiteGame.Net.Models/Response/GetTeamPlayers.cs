using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Lists the players for a particular clan.
    /// </summary>
    public class GetTeamPlayers
    {
        [JsonPropertyName("AccountLevel")]
        public int AccountLevel { get; private set; }

        [JsonPropertyName("JoinedDatetime")]
        public string? JoinedDatetime { get; private set; }

        [JsonPropertyName("LastLoginDatetime")]
        public string? LastLoginDatetime { get; private set; }

        [JsonPropertyName("Name")]
        public string? Name { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}