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
        public Connectivity(HirezCredentials credentials)
            : base(credentials) { }

        public async Task<string> Ping()
        {
            RestRequest request = CreateSimpleRequest(nameof(Ping));
            return await HandleResponse<string>(request);
        }

        public async Task<CreateSession> CreateSession()
        {
            RestRequest request = CreateAuthRequest();
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
            string methodName = nameof(TestSession).ToLower();
            RestRequest request = CreateRequest(methodName);
            return await HandleResponse<string>(request);
        }

        public async Task<HirezServerStatus> GetHirezServerStatus()
        {
            string methodName = nameof(GetHirezServerStatus).ToLower();
            RestRequest request = CreateRequest(methodName);
            var response = await HandleResponse<IEnumerable<HirezServerStatus>>(request);
            return response.First();
        }
    }
}
