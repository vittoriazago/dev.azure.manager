using DevAzureManager.Models.Azure;

namespace DevAzureManager.Models
{
    public class ApprovalsRequestDto
    {
        public Status Status { get; set; }

        public string Comments { get; set; }
        public long Id { get; set; }
    }
}
