using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Returns API Developer daily usage limits and the current status against those limits.
    /// </summary>
    public class GetDataUsed
    {
        [JsonPropertyName("Active_Sessions")]
        public int ActiveSessions { get; private set; }

        [JsonPropertyName("Concurrent_Sessions")]
        public int ConcurrentSessions { get; private set; }

        [JsonPropertyName("Request_Limit_Daily")]
        public int RequestLimitDaily { get; private set; }

        [JsonPropertyName("Session_Cap")]
        public int SessionCap { get; private set; }

        [JsonPropertyName("Session_Time_Limit")]
        public int SessionTimeLimit { get; private set; }

        [JsonPropertyName("Total_Requests_Today")]
        public int TotalRequestsToday { get; private set; }

        [JsonPropertyName("Total_Sessions_Today")]
        public int TotalSessionsToday { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}