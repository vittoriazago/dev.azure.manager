using System;
using System.Collections.Generic;
using DevAzureManager.Models.Azure;

namespace DevAzureManager.Models
{
    public partial class ApprovalsPendingCountDto
    {
        public long Count { get; set; }

        public List<ApprovalsPendingDto> Value { get; set; }
    }

    public partial class ApprovalsPendingDto
    {
        public long Id { get; set; }

        public long Revision { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }

        public Status Status { get; set; }
        
        public long ReleaseId { get; set; }
        public string ReleaseName { get; set; }
        public long ReleaseDefinitionId { get; set; }
        public string ReleaseDefinitionName { get; set; }

        public string ReleaseEnviromentName { get; set; }
    }

}
