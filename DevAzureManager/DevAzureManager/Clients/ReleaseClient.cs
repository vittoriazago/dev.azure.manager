using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DevAzureManager.Models.Azure;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace DevAzureManager.Clients
{
    public class ReleaseClient : BaseClient, IReleaseClient
    {
        public ReleaseClient(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync(Status status)
        {
            var url = $"{BaseUri}_apis/release/approvals?continuationToken=0&statusFilter={status}";
            HttpResponseMessage response = await Client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = ApprovalsPendingVSTSCountDto.FromJson(
                                        await response.Content.ReadAsStringAsync());
            return responseBody;
        }

        public async Task<ReleaseDetailVSTSDto> GetReleaseDetail(long idRelease)
        {
            var url = $"{BaseUri}_apis/release/releases/{idRelease}";
            HttpResponseMessage response = await Client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsAsync<ReleaseDetailVSTSDto>();
            return responseBody;
        }

        public async Task PostApprovalPendingAsync(long approvalId,
                    ApprovalsRequestVSTSDto approve)
        {
            var url = $"{BaseUri}_apis/release/approvals/{approvalId}?api-version=5.2-preview";

            HttpResponseMessage response = await Client.SendAsync(new HttpRequestMessage()
            {
                Method = HttpMethod.Patch,
                RequestUri = new Uri(url),
                Content = new StringContent(JsonConvert.SerializeObject(approve),
                                    Encoding.UTF8,
                                    "application/json"),
            });
            response.EnsureSuccessStatusCode();
        }
    }

}
