namespace movie_night_part_2
{
    public class Genre
    {
        // attributes of Genre object
        public int Gen_id { get; set; }
        public string Gen_type { get; set; }

        // constructor with 0 parameter
        public Genre()
        {
            
        }

        // constructer with 1 parameter
        public Genre(int gen_id)
        {
            this.Gen_id = gen_id;
        }
        // constructor with 1 parameter
        public Genre(string gen_type)
        
        {
            this.Gen_type = gen_type;
        }

        // constructor with 2 parameter
        public Genre(int gen_id, string gen_type)
        :this(gen_id)
        {
            this.Gen_type = gen_type;
        }
    }
}