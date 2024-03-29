using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Models.Response;

namespace SmiteGame.Net.Apis
{
    public class Team : ApiBase
    {
        public Team(RestClient client, HirezCredentials credentials, Options options)
            : base(client, credentials, options) { }

        /// <summary>
        /// Lists the number of players and other high level details for a particular clan.
        /// <paramref name="clanId"/>: The ID of the clan.
        /// </summary>
        public async Task<GetTeamDetails> GetTeamDetails(string clanId)
        {
            RestRequest request = CreateRequest("getteamdetails", clanId);
            var response = await HandleResponse<IEnumerable<GetTeamDetails>>(request);
            return response.First();
        }

        /// <summary>
        /// Lists the players for a particular clan.
        /// <paramref name="clanId"/>: The ID of the clan.
        /// </summary>
        public async Task<IEnumerable<GetTeamPlayers>> GetTeamPlayers(string clanId)
        {
            RestRequest request = CreateRequest("getteamplayers", clanId);
            return await HandleResponse<IEnumerable<GetTeamPlayers>>(request);
        }

        /// <summary>
        /// Returns high level information for Clan names containing the “searchTeam” string.
        /// <paramref name="searchTeam"/>: The name of the clan to search.
        /// </summary>
        public async Task<IEnumerable<SearchTeams>> SearchTeams(string searchTeam)
        {
            RestRequest request = CreateRequest("searchteams", searchTeam);
            return await HandleResponse<IEnumerable<SearchTeams>>(request);
        }
    }
}