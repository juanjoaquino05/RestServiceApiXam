using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestServiceApiXam.Models
{
    public class Creator
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("image_background")]
        public string image_background { get; set; }

        [JsonProperty("games_count")]
        public int games_count { get; set; }

        [JsonProperty("positions")]
        public IList<Position> positions { get; set; }

        [JsonProperty("games")]
        public IList<Game> games { get; set; }
    }
}
