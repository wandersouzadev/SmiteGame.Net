using System;
using SmiteGame.Net.Apis;
using SmiteGame.Net.Configuration;

namespace SmiteGame.Net
{
    public sealed class SmiteGameDotNet
    {
        public readonly Connectivity connectivity;
        public readonly Other other;

        public SmiteGameDotNet(HirezCredentials credentials)
        {
            if (
                string.IsNullOrWhiteSpace(credentials.DevId)
                || string.IsNullOrWhiteSpace(credentials.AuthKey)
            )
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            connectivity = new Connectivity(credentials);
            other = new Other(credentials);
        }

        public static string SessionId { get; set; } = string.Empty;
    }
}
