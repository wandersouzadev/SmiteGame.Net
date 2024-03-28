using System.Text.Json.Serialization;

namespace SmiteGame.Net.Models.Response
{
    /// <summary>
    /// Function returns information about current deployed patch. Currently, this information only includes patch version.
    /// </summary>
    public class GetPatchInfo
    {
        [JsonPropertyName("version_string")]
        public string? VersionString { get; private set; }

        [JsonPropertyName("ret_msg")]
        public string? RetMsg { get; private set; }
    }
}
