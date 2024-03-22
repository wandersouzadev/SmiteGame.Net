using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// A required step to Authenticate the developerId/signature for further API use.
    /// </summary>
    public class CreateSession
    {
        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }

        [JsonPropertyName("session_id")]
        public string? SessionId { get; private set; }

        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; private set; }
    }

}