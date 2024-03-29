using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Models.Enums;
using SmiteGame.Net.Models.Response;

namespace SmiteGame.Net.Apis
{
    public class League : ApiBase
    {
        public League(RestClient client, HirezCredentials credentials)
            : base(client, credentials) { }

        /// <summary>
        /// Returns the top players for a particular league (as indicated by the queue/tier/round parameters).
        /// Note: the “Season” for which the Round is associated is by default the current/active Season.
        /// <paramref name="queue"/>: The queue to get the top players for.
        /// <paramref name="tier"/>: The tier to get the top players for.
        /// <paramref name="round"/>: The round to get the top players for (eg. 2 for the 2nd round, the default is current round).
        /// </summary>
        public async Task<IEnumerable<GetLeagueLeaderboard>> GetLeagueLeaderboard(
            QueueId queue,
            Tier tier,
            int round = 0
        )
        {
            RestRequest request = CreateRequest("getleagueleaderboard", queue, tier, round);
            return await HandleResponse<IEnumerable<GetLeagueLeaderboard>>(request);
        }

        /// <summary>
        /// Provides a list of seasons and rounds (including the single active season) for a match queue.
        /// <paramref name="queue"/>: The queue to get the sessions for.
        /// </summary>
        public async Task<IEnumerable<GetLeagueSeasons>> GetLeagueSeasons(RankedQueueId queue)
        {
            RestRequest request = CreateRequest("getleagueseasons", queue);
            return await HandleResponse<IEnumerable<GetLeagueSeasons>>(request);
        }
    }
}
