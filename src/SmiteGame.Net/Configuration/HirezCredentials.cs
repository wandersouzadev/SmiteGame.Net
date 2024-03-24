namespace SmiteGame.Net.Configuration
{
    public struct HirezCredentials
    {
        public HirezCredentials(string apiKey, string devId)
        {
            ApiKey = apiKey;
            DevId = devId;
        }

        public string ApiKey { get; private set; }
        public string DevId { get; private set; }
    }
}
