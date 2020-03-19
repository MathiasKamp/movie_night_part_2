namespace movie_night_part_2
{
    public class Genre
    {
        public int Gen_id { get; set; }
        public string Gen_type { get; set; }

        public Genre()
        {
            
        }

        public Genre(int gen_id)
        {
            this.Gen_id = gen_id;
        }

        public Genre(string gen_type)
        
        {
            this.Gen_type = gen_type;
        }

        public Genre(int gen_id, string gen_type)
        :this(gen_id)
        {
            this.Gen_type = gen_type;
        }
    }
}