using System;
using System.Text.Json;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace TP_CAPI.Libraries
{
    public class FacebookClient
    {
        private const string apiVersion = "9.0";
        private const string BASE_URL = "https://graph.facebook.com/v" + apiVersion + "/";

        private string accessToken;

        public FacebookClient(string accessToken)
        {
            this.accessToken = accessToken;
        }

        public async Task<HttpResponseMessage> postAsync(string payload, string endpoint)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BASE_URL);

                Dictionary<string, string> paramData = new Dictionary<string, string>
                {
                    { "access_token",  accessToken },
                    { "data", payload }
                };

                HttpResponseMessage responseMessage;

                var encodedContent = new FormUrlEncodedContent(paramData);
                responseMessage = await httpClient.PostAsync(endpoint, encodedContent);
                responseMessage.EnsureSuccessStatusCode();

                return responseMessage;
            }
        }
    }
}
