using System;
using System.Threading.Tasks;
using RestSharp;
using SmiteGame.Net.Configuration;
using SmiteGame.Net.Helpers;

namespace SmiteGame.Net.Apis
{
    public abstract class ApiBase
    {
        private readonly RestClient _restClient;
        private readonly HirezCredentials _credentials;
        private readonly ResponseFormat _apiResponseFormat = ResponseFormat.Json;

        protected string? SessionId { get; set; }

        public ApiBase(RestClient restClient, HirezCredentials credentials, Options options)
        {
            _restClient = restClient;
            _credentials = credentials;
            SessionId = options.SessionId;
        }

        protected RestRequest CreateSimpleRequest(string resource)
        {
            return new RestRequest(resource, Method.GET);
        }

        protected RestRequest CreateRequest(string resource, params dynamic[] args)
        {
            Signature signature = HirezSignatureHelper.CreateSignature(_credentials, resource);
            var uri =
                $"{resource}{_apiResponseFormat}/{_credentials.DevId}/{signature.Hash}{(resource != "createsession" ? "/" + SessionId : "")}/{signature.Timestamp}";

            if (args.Length == 0)
            {
                Console.WriteLine(uri);
                return new RestRequest(uri, Method.GET);
            }

            foreach (var arg in args)
            {
                Type argType = arg.GetType();
                string argValue = string.Empty;

                if (argType.IsEnum || arg is int)
                {
                    argValue = ((int)arg).ToString();
                }
                else if (argType == typeof(string))
                {
                    argValue = Uri.EscapeDataString((string)arg);
                }

                uri += $"/{argValue}";
            }

            Console.WriteLine(resource);
            Console.WriteLine(uri);

            return new RestRequest(uri, Method.GET);
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
