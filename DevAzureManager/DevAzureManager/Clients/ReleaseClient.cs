using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DevAzureManager.Models;
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

        public async Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync(StatusRelease status)
        {
            var url = BaseUri + $"_apis/release/approvals?continuationToken=0&statusFilter={status}";
            HttpResponseMessage response = await Client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = ApprovalsPendingVSTSCountDto.FromJson(
                                        await response.Content.ReadAsStringAsync());
            return responseBody;
        }

        public async Task<ReleaseDetailVSTSDto> GetReleaseDetail(long idRelease)
        {
            var url = BaseUri + $"_apis/release/releases/{idRelease}";
            HttpResponseMessage response = await Client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsAsync<ReleaseDetailVSTSDto>();
            return responseBody;
        }

    }

    public enum StatusRelease
    {
        approved,
        canceled,
        pending,
        reassigned,
        rejected,
        skipped,
        undefined
    }
}
