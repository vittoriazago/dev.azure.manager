using DevAzureManager.Models.Azure;
using System.Threading.Tasks;

namespace DevAzureManager.Clients
{
    public interface IReleaseClient
    {
        public Task<ReleaseDetailVSTSDto> GetReleaseDetail(long idRelease);
        public Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync(Status status);
        public Task PostApprovalPendingAsync(long approvalId, ApprovalsRequestVSTSDto approve);
    }
}
