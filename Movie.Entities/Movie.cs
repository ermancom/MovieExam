using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Entities
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set;}

        public int YearOfRelease { get; set; }

        public int RunningTime { get; set; }

        public string Genres { get; set; }

        public ICollection<MovieRate> MovieRates { get; set; }

    }
}
