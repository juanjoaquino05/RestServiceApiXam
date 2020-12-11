using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServiceApiXam.Models
{
    public class Position
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("slug")]
        public string slug { get; set; }
    }
}
