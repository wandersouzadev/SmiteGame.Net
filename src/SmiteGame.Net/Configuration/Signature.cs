namespace SmiteGame.Net.Configuration
{
    public struct Signature
    {
        public string Hash { get; set; }
        public string Timestamp { get; set; }

        public Signature(string hash, string timestamp)
        {
            Hash = hash;
            Timestamp = timestamp;
        }
    }
}
