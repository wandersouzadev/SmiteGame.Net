using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Models.Response;

namespace SmiteGame.Net.Apis
{
    public class Other : ApiBase
    {
        public Other(HirezCredentials credentials)
            : base(credentials) { }

        public async Task<IEnumerable<GetMOTD>> GetMotd()
        {
            string methodName = nameof(GetMotd).ToLower();
            RestRequest request = CreateRequest(methodName);
            return await HandleResponse<IEnumerable<GetMOTD>>(request);
        }

        public async Task<IEnumerable<GetEsportsProLeagueDetails>> GetEsportsProLeagueDetails()
        {
            string methodName = nameof(GetEsportsProLeagueDetails).ToLower();
            RestRequest request = CreateRequest(methodName);
            return await HandleResponse<IEnumerable<GetEsportsProLeagueDetails>>(request);
        }
    }
}
