using DevAzureManager.Models.Azure;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevAzureManager.Clients
{
    public class ReleaseClient : BaseClient, IReleaseClient
    {
        public ReleaseClient(IConfiguration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Get releases with status
        /// </summary>
        public async Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync(
            string user, string token, Status? status = null)
        {
            GetAuthorizationHeader(user, token);
            var url = new Uri(BaseUri, $"_apis/release/approvals?continuationToken=0&status={status}");

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = ApprovalsPendingVSTSCountDto.FromJson(
                                        await response.Content.ReadAsStringAsync());
            return responseBody;
        }

        /// <summary>
        /// Get details of one release
        /// </summary>
        public async Task<ReleaseDetailVSTSDto> GetReleaseDetail(long idRelease)
        {
            var url = new Uri(BaseUri, $"_apis/release/releases/{idRelease}");

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsAsync<ReleaseDetailVSTSDto>();
            return responseBody;
        }

        /// <summary>
        /// Post approve to releases
        /// </summary>
        public async Task<HttpStatusCode> PostApprovalPendingAsync(
                    string user, string token, long approvalId,
                    ApproveRequestVSTSDto approve)
        {
            var url = new Uri(BaseUri, $"_apis/release/approvals/{approvalId}?api-version=5.2-preview");
            GetAuthorizationHeader(user, token);

            var response = await _httpClient.SendAsync(new HttpRequestMessage()
            {
                Method = HttpMethod.Patch,
                RequestUri = url,
                Content = new StringContent(JsonConvert.SerializeObject(approve),
                                    Encoding.UTF8,
                                    "application/json"),
            });
            response.EnsureSuccessStatusCode();
            return response.StatusCode;
        }
    }
}
