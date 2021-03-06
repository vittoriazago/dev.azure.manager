
using Newtonsoft.Json;
using System;

namespace DevAzureManager.Models.Azure
{
    public partial class ApproveVSTSResponseDto
    {
        [JsonProperty("approvedBy")]
        public ApprovedBy ApprovedBy { get; set; }

        [JsonProperty("approver")]
        public ApprovedBy Approver { get; set; }

        [JsonProperty("attempt")]
        public long Attempt { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("history")]
        public History[] History { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("isAutomated")]
        public bool IsAutomated { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTimeOffset ModifiedOn { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("release")]
        public Release Release { get; set; }

        [JsonProperty("releaseDefinition")]
        public ReleaseDefinition ReleaseDefinition { get; set; }

        [JsonProperty("releaseEnvironment")]
        public Release ReleaseEnvironment { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class ApprovedBy
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("directoryAlias")]
        public string DirectoryAlias { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("isAadIdentity")]
        public bool IsAadIdentity { get; set; }

        [JsonProperty("isContainer")]
        public bool IsContainer { get; set; }

        [JsonProperty("isDeletedInOrigin")]
        public bool IsDeletedInOrigin { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("links")]
        public LinksClass LinksLinks { get; set; }
    }

    public partial class LinksClass
    {
        [JsonProperty("additionalProp1")]
        public AdditionalProp AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public AdditionalProp AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public AdditionalProp AdditionalProp3 { get; set; }
    }

    public partial class AdditionalProp
    {
    }

    public partial class History
    {
        [JsonProperty("approver")]
        public ApprovedBy Approver { get; set; }

        [JsonProperty("changedBy")]
        public ApprovedBy ChangedBy { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("createdOn")]
        public DateTimeOffset CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTimeOffset ModifiedOn { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }
    }

    public partial class ProjectReference
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class ApproveVSTSResponseDto
    {
        public static ApproveVSTSResponseDto FromJson(string json) => JsonConvert.DeserializeObject<ApproveVSTSResponseDto>(json, Converter.Settings);
    }

}



