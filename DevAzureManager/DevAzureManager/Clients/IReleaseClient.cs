using DevAzureManager.Models.Azure;
using System.Net;
using System.Threading.Tasks;

namespace DevAzureManager.Clients
{
    public interface IReleaseClient
    {
        Task<ApprovalsPendingVSTSCountDto> GetApprovalPendingAsync(string user, string token, Status? status = null);
        Task<ReleaseDetailVSTSDto> GetReleaseDetail(long idRelease);
        Task<HttpStatusCode> PostApprovalPendingAsync(string user, string token, long approvalId,
                     ApproveRequestVSTSDto approve);
    }
}
