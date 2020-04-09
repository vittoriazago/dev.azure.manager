using System;
using System.Collections.Generic;

namespace DevAzureManager.Models
{
    public class ReleaseResponseDto
    {
        public long Count { get; set; }

        public List<ReleaseResponseListDto> Value { get; set; }
    }

    public class ReleaseResponseListDto
    {
        public int Id { get; set; }
        public string IdRelease { get; set; }
        public string NameRelease { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public string NameReleaseDefinition { get; set; }
        public string Enviroment { get; set; }
    }
}
