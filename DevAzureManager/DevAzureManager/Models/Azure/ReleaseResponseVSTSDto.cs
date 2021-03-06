using System;
using System.Collections.Generic;

namespace DevAzureManager.Models.Azure
{
    public partial class ReleaseResponseVSTSDto
    {
        public long Count { get; set; }

        public List<ReleaseResponseListVSTSDto> Value { get; set; }
    }

    public class ReleaseResponseListVSTSDto
    {
        public int id { get; set; }
        public int revision { get; set; }
        public string approvalType { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
        public bool isAutomated { get; set; }
        public bool isNotificationOn { get; set; }
        public int trialNumber { get; set; }
        public int attempt { get; set; }
        public int rank { get; set; }
        public Release release { get; set; }
        public ReleaseDefinition releaseDefinition { get; set; }
        public ReleaseEnvironment releaseEnvironment { get; set; }
        public string url { get; set; }
    }


    public class ReleaseEnvironment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
