using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace movie_night_part_2
{
    public class Movie
    {
        public int Mov_id { get; set; }
        public int Mov_year { get; set; }
        public string Mov_title { get; set; }
        public string Mov_description { get; set; }

       


        public Movie()
        {
            
        }
        public Movie(string title, string description)
        {
            this.Mov_title = title;
            this.Mov_description = description;
        }

        public Movie(int year, string title, string description) 
            :this(title, description)
        {
            this.Mov_year = year;
        }

        public Movie(int mov_id, int year, string title, string description)
        :this(year,title,description)
        {
            this.Mov_id = mov_id;
        }
    }
}