
using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Function returns UP/DOWN status for the primary game/platform environments.  Data is cached once a minute.
    /// </summary>
    public class HirezServerStatus
    {
        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }

        [JsonPropertyName("status")]
        public string? Status { get; private set; }

        [JsonPropertyName("limited_access")]
        public bool LimitedAccess { get; private set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; private set; }

        [JsonPropertyName("environment")]
        public string? Environment { get; private set; }

        [JsonPropertyName("entry_datetime")]
        public string? EntryDatetime { get; private set; }
    }
}