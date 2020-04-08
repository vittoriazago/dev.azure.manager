
using System;
using System.Collections.Generic;

using System.Globalization;
using DevAzureManager.Models.Azure;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevAzureManager.Models
{

    public partial class ReleaseDetailDto
    {
        public long Id { get; set; }

        public string CreatedBy { get; set; }

        public string Branch { get; set; }
    }

}
