using Newtonsoft.Json;


namespace Movie.Entities.Models
{
    public class MovieModel
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

        [JsonProperty("averageRating")]
        public double AverageRating { get; set; }

    }
}
