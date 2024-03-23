using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Returns the matchup information for each matchup for the current eSports Pro League season. 
    /// An important return value is “match_status” which represents a match being scheduled (1), in-progress (2), or complete (3)
    /// </summary>
    public class GetEsportsProLeagueDetails
    {
        [JsonPropertyName("away_team_clan_id")]
        public int AwayTeamClanId { get; private set; }

        [JsonPropertyName("away_team_name")]
        public string? AwayTeamName { get; private set; }

        [JsonPropertyName("away_team_tagname")]
        public string? AwayTeamTagname { get; private set; }

        [JsonPropertyName("home_team_clan_id")]
        public int HomeTeamClanId { get; private set; }

        [JsonPropertyName("home_team_name")]
        public string? HomeTeamName { get; private set; }

        [JsonPropertyName("home_team_tagname")]
        public string? HomeTeamTagname { get; private set; }

        [JsonPropertyName("map_instance_id")]
        public string? MapInstanceId { get; private set; }

        [JsonPropertyName("match_date")]
        public string? MatchDate { get; private set; }

        [JsonPropertyName("match_number")]
        public string? MatchNumber { get; private set; }

        [JsonPropertyName("match_status")]
        public string? MatchStatus { get; private set; }

        [JsonPropertyName("matchup_id")]
        public string? MatchupId { get; private set; }

        [JsonPropertyName("region")]
        public string? Region { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }

        [JsonPropertyName("tournament_name")]
        public string? TournamentName { get; private set; }

        [JsonPropertyName("winning_team_clan_id")]
        public int WinningTeamClanId { get; private set; }
    }

}