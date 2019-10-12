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

        public async Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync()
        {
            var url = BaseUri + "_apis/release/approvals?continuationToken=0";
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = ApprovalsPendingVSTSCountDto.FromJson(
                                        await response.Content.ReadAsStringAsync());
            return responseBody;
        }
    }
}
