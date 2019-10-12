
using System;
using System.Collections.Generic;

using System.Globalization;
using DevAzureManager.Models.Azure;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevAzureManager.Models
{
    public partial class ApprovalsPendingCountDto
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("value")]
        public List<ApprovalsPendingDto> Value { get; set; }
    }

    public partial class ApprovalsPendingDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTimeOffset ModifiedOn { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }


        public long ReleaseId { get; set; }
        public string ReleaseName { get; set; }
        public long ReleaseDefinitionId { get; set; }
        public string ReleaseDefinitionName { get; set; }

        public string ReleaseEnviromentName { get; set; }
    }

}
