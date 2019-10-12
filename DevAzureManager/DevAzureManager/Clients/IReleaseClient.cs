using DevAzureManager.Models;
using DevAzureManager.Models.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevAzureManager.Clients
{
    public interface IReleaseClient
    {
        Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync();
    }
}
