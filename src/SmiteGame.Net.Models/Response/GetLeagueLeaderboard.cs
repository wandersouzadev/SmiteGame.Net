using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    public class GetLeagueLeaderboard
    {
        [JsonPropertyName("Leaves")]
        public int Leaves { get; private set; }

        [JsonPropertyName("Losses")]
        public int Losses { get; private set; }

        [JsonPropertyName("Name")]
        public string? Name { get; private set; }

        [JsonPropertyName("Points")]
        public int Points { get; private set; }

        [JsonPropertyName("PrevRank")]
        public int PrevRank { get; private set; }

        [JsonPropertyName("Rank")]
        public int Rank { get; private set; }

        [JsonPropertyName("Rank_Stat")]
        public int RankStat { get; private set; }

        [JsonPropertyName("Rank_Stat_Conquest")]
        public string? RankStatConquest { get; private set; }

        [JsonPropertyName("Rank_Stat_Joust")]
        public string? RankStatJoust { get; private set; }

        [JsonPropertyName("Rank_Variance")]
        public int Rank_Variance { get; private set; }

        [JsonPropertyName("Season")]
        public int Season { get; private set; }

        [JsonPropertyName("Tier")]
        public int Tier { get; private set; }

        [JsonPropertyName("Trend")]
        public int Trend { get; private set; }

        [JsonPropertyName("Wins")]
        public int Wins { get; private set; }

        [JsonPropertyName("player_id")]
        public string? PlayerId { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}
