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
        public Connectivity(RestClient client, HirezCredentials credentials)
            : base(client, credentials) { }

        public async Task<string> Ping()
        {
            RestRequest request = CreateSimpleRequest(nameof(Ping));
            return await HandleResponse<string>(request);
        }

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

        public async Task<string> TestSession()
        {
            RestRequest request = CreateRequest("testsession");
            return await HandleResponse<string>(request);
        }

        public async Task<GetDataUsed> GetDataUsed()
        {
            RestRequest request = CreateRequest("getdataused");
            var response = await HandleResponse<IEnumerable<GetDataUsed>>(request);
            return response.First();
        }

        public async Task<GetPatchInfo> GetPatchInfo()
        {
            RestRequest request = CreateRequest("getpatchinfo");
            return await HandleResponse<GetPatchInfo>(request);
        }

        public async Task<HirezServerStatus> GetHirezServerStatus()
        {
            RestRequest request = CreateRequest("gethirezserverstatus");
            var response = await HandleResponse<IEnumerable<HirezServerStatus>>(request);
            return response.First();
        }
    }
}
