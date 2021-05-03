using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Trailer
    {
        public int Id { get; set; }

        //public int MovieID { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }

        public int MovieID { get; set; }

        // Migration Property (We can get to Movie if we need to)
        public Movie Movie { get; set; }
    }
}
