using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Models.Response;

namespace SmiteGame.Net.Apis
{
    public class Connectivity : ApiBase
    {
        public Connectivity(RestClient client, HirezCredentials credentials, Options options)
            : base(client, credentials, options) { }

        /// <summary>
        /// A quick way of validating access to the Hi-Rez API.
        /// </summary>
        public async Task<string> Ping()
        {
            RestRequest request = CreateSimpleRequest(nameof(Ping));
            return await HandleResponse<string>(request);
        }

        /// <summary>
        /// A required step to Authenticate the developerId/signature for further API use.
        /// </summary>
        public async Task<CreateSession> CreateSession()
        {
            RestRequest request = CreateRequest("createsession");
            var response = await HandleResponse<CreateSession>(request);
            if (
                response.RetMsg is null
                || response.SessionId is null
                || !response.RetMsg.Contains("Approved")
            )
            {
                throw new Exception(response.RetMsg);
            }
            SessionId = response.SessionId;
            return response;
        }

        /// <summary>
        /// A means of validating that a session is established.
        /// </summary>
        public async Task<string> TestSession()
        {
            RestRequest request = CreateRequest("testsession");
            return await HandleResponse<string>(request);
        }

        /// <summary>
        /// Returns API Developer daily usage limits and the current status against those limits.
        /// </summary>
        public async Task<GetDataUsed> GetDataUsed()
        {
            RestRequest request = CreateRequest("getdataused");
            var response = await HandleResponse<IEnumerable<GetDataUsed>>(request);
            return response.First();
        }

        /// <summary>
        /// Function returns information about current deployed patch. Currently, this information only includes patch version.
        /// </summary>
        public async Task<GetPatchInfo> GetPatchInfo()
        {
            RestRequest request = CreateRequest("getpatchinfo");
            return await HandleResponse<GetPatchInfo>(request);
        }

        /// <summary>
        /// Function returns UP/DOWN status for the primary game/platform environments.  Data is cached once a minute.
        /// </summary>
        public async Task<HirezServerStatus> GetHirezServerStatus()
        {
            RestRequest request = CreateRequest("gethirezserverstatus");
            var response = await HandleResponse<IEnumerable<HirezServerStatus>>(request);
            return response.First();
        }
    }
}
