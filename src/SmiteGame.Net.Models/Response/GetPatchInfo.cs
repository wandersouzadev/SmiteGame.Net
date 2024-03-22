using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Function returns information about current deployed patch. Currently, this information only includes patch version.
    /// </summary>
    public class GetPatchInfo
    {
        [JsonPropertyName("version")]
        public string? Version { get; private set; }

        [JsonPropertyName("version_id")]
        public string? VersionId { get; private set; }

        [JsonPropertyName("version_code")]
        public string? VersionCode { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }

}