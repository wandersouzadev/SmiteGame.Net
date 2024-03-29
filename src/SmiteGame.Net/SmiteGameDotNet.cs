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

        public SmiteGameDotNet(HirezCredentials credentials)
        {
            if (
                string.IsNullOrWhiteSpace(credentials.DevId)
                || string.IsNullOrWhiteSpace(credentials.AuthKey)
            )
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            Connectivity = new Connectivity(_client, credentials);
            Other = new Other(_client, credentials);
        }

        public Connectivity Connectivity { get; }
        public Other Other { get; }
    }
}
