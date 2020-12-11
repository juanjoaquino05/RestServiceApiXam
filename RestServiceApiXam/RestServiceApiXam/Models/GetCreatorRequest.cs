using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServiceApiXam.Models
{
    public class GetCreatorResponse
    {
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("next")]
        public string next { get; set; }

        [JsonProperty("previous")]
        public object previous { get; set; }

        [JsonProperty("results")]
        public IList<Creator> results { get; set; }
    }
}
