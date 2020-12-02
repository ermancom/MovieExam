using System;
using System.Collections.Generic;

namespace Movie.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string Fullname { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public ICollection<MovieRate> MovieRates { get; set; }
    }
}
