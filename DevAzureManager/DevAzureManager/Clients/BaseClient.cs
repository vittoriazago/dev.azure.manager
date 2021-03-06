using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DevAzureManager.Clients
{
    public abstract class BaseClient
    {
        public BaseClient(IConfiguration configuration)
        {
            Configuration = configuration;
            Project = configuration["APPSETTINGS:PROJECT"];
            Organization = configuration["APPSETTINGS:ORGANIZATION"];

            var baseUriApi = configuration["APPSETTINGS:BASEURI"] + Organization + "/" + Project + "/";
            BaseUri = new Uri(baseUriApi);

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        public void GetAuthorizationHeader(string user, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                            string.Format("{0}:{1}", user, token))));
        }
        public IConfiguration Configuration { get; }
        public HttpClient _httpClient { get; }
        public string Organization { get; }
        public string Project { get; }
        public Uri BaseUri { get; }

    }

}
