using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Entities
{
    public class MovieRate
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int MovieID { get; set; }

        public int UserRate { get; set; } 

        public User MovieUser { get; set; }

        public Movie Movie { get; set; }
    }
}
