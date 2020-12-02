using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Entities.Models
{
    public class MovieRateModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("yearOfRelease")]
        public int YearOfRelease { get; set; }

        [JsonProperty("runningTime")]
        public int RunningTime { get; set; }

        [JsonProperty("genres")]
        public string Genres { get; set; }

        [JsonProperty("userRate")]
        public int UserRate { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
