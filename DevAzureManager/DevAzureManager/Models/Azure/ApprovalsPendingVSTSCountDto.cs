using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevAzureManager.Models.Azure
{
    public partial class ApprovalsPendingVSTSCountDto
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("value")]
        public List<ApprovalsPendingVSTSDto> Value { get; set; }
    }

    public partial class ApprovalsPendingVSTSDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("approver")]
        public Approver Approver { get; set; }

        [JsonProperty("approvalType")]
        public string ApprovalType { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTimeOffset ModifiedOn { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("isAutomated")]
        public bool IsAutomated { get; set; }

        [JsonProperty("isNotificationOn")]
        public bool IsNotificationOn { get; set; }

        [JsonProperty("trialNumber")]
        public long TrialNumber { get; set; }

        [JsonProperty("attempt")]
        public long Attempt { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("release")]
        public Release Release { get; set; }

        [JsonProperty("releaseDefinition")]
        public ReleaseDefinition ReleaseDefinition { get; set; }

        [JsonProperty("releaseEnvironment")]
        public Release ReleaseEnvironment { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Approver
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public ApproverLinks Links { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("isContainer")]
        public bool IsContainer { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }
    }

    public partial class ApproverLinks
    {
        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class Release
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public ReleaseLinks Links { get; set; }
    }

    public partial class ReleaseLinks
    {
    }

    public partial class ReleaseDefinition
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("projectReference")]
        public object ProjectReference { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public ReleaseLinks Links { get; set; }
    }

    public enum Status { Pending, Undefined, Approved, Rejected, Reassigned, Canceled, Skipped };

    public partial class ApprovalsPendingVSTSCountDto
    {
        public static ApprovalsPendingVSTSCountDto FromJson(string json) => JsonConvert.DeserializeObject<ApprovalsPendingVSTSCountDto>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ApprovalsPendingVSTSCountDto self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

}
