using System;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Helpers;

namespace SmiteGame.Net.Apis
{
    public abstract class ApiBase
    {
        protected RestClient _restClient = new RestClient(
            "https://api.smitegame.com/smiteapi.svc/"
        );
        protected HirezCredentials _credentials;
        protected ResponseFormat _apiResponseFormat = ResponseFormat.Json;

        protected string SessionId { get; set; } = string.Empty;

        public ApiBase(HirezCredentials credentials)
        {
            _credentials = credentials;
        }

        protected RestRequest CreateSimpleRequest(string resource)
        {
            RestRequest request = new RestRequest()
            {
                Resource = $"{resource}{_apiResponseFormat}"
            };
            request.AddHeader("Content-Type", "application/json");
            return request;
        }

        protected RestRequest CreateAuthRequest()
        {
            Signature signature = HirezSignatureHelper.CreateSignature(
                _credentials,
                "createsession"
            );
            RestRequest request = new RestRequest()
            {
                Resource =
                    $"createsession{_apiResponseFormat}/{_credentials.DevId}/{signature.Hash}/{signature.Timestamp}"
            };
            request.AddHeader("Content-Type", "application/json");
            return request;
        }

        protected RestRequest CreateRequest(string resource, params string[] args)
        {
            // DEBUG TEST SESSION ID
#if DEBUG
            SessionId = "A6AFB1BC6ACA4C08A4189AC64432A513";
#endif

            Signature signature = HirezSignatureHelper.CreateSignature(_credentials, resource);

            RestRequest request = new RestRequest()
            {
                Resource =
                    $"{resource}{_apiResponseFormat}/{_credentials.DevId}/{signature.Hash}/{SessionId}/{signature.Timestamp}"
            };
            request.AddHeader("Content-Type", "application/json");
            return request;
        }

        protected async Task<T> HandleResponse<T>(RestRequest request)
        {
            var response = await _restClient.ExecuteGetAsync<T>(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK || response.Data == null)
            {
                throw new Exception(response.ErrorMessage);
            }

            return response.Data;
        }
    }
}
