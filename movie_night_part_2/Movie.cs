using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace movie_night_part_2
{
    public class Movie
    {

        // attributes of a movie object
        public int Mov_id { get; set; }
        public int Mov_year { get; set; }
        public string Mov_title { get; set; }
        public string Mov_description { get; set; }

       

        // constructor with 0 parameter
        public Movie()
        {
            
        }

        // constructor with 2 parameter
        public Movie(string title, string description)
        {
            this.Mov_title = title;
            this.Mov_description = description;
        }

        // constructor with 3 parameter
        public Movie(int year, string title, string description) 
            :this(title, description)
        {
            this.Mov_year = year;
        }

        // constructor with 4 parameter
        public Movie(int mov_id, int year, string title, string description)
        :this(year,title,description)
        {
            this.Mov_id = mov_id;
        }
    }
}