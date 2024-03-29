using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Models.Response;

namespace SmiteGame.Net.Apis
{
    public class Other : ApiBase
    {
        public Other(RestClient restClient, HirezCredentials credentials)
            : base(restClient, credentials) { }

        /// <summary>
        /// Returns the matchup information for each matchup for the current eSports Pro League season.
        /// An important return value is “match_status” which represents a match being scheduled (1), in-progress (2), or complete (3)
        /// </summary>
        public async Task<IEnumerable<GetEsportsProLeagueDetails>> GetEsportsProLeagueDetails()
        {
            RestRequest request = CreateRequest("getesportsproleaguedetails");
            return await HandleResponse<IEnumerable<GetEsportsProLeagueDetails>>(request);
        }

        /// <summary>
        /// Returns information about the 20 most recent Match-of-the-Days.
        /// </summary>
        public async Task<IEnumerable<GetMOTD>> GetMotd()
        {
            RestRequest request = CreateRequest("getmotd");
            return await HandleResponse<IEnumerable<GetMOTD>>(request);
        }
    }
}
