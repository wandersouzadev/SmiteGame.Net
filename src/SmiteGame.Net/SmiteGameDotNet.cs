using System;
using RestSharp;
using SmiteGame.Net.Apis;
using SmiteGame.Net.Configuration;

namespace SmiteGame.Net
{
    public sealed class SmiteGameDotNet
    {
        private readonly RestClient _client = new RestClient(
            "https://api.smitegame.com/smiteapi.svc/"
        );
        private readonly RestRequest _request = new RestRequest();

        public SmiteGameDotNet(HirezCredentials credentials, Options options = new Options())
        {
            if (
                string.IsNullOrWhiteSpace(credentials.DevId)
                || string.IsNullOrWhiteSpace(credentials.AuthKey)
            )
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            Connectivity = new Connectivity(_client, credentials, options);
            Other = new Other(_client, credentials, options);
            Team = new Team(_client, credentials, options);
            League = new League(_client, credentials, options);
        }

        public Connectivity Connectivity { get; }
        public Other Other { get; }
        public Team Team { get; }
        public League League { get; }
    }
}
