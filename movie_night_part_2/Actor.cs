namespace movie_night_part_2
{
    public class Actor
    {
        public int Act_id { get; set; }
        public string act_fname { get; set; }
        public string act_lname { get; set; }

        // dette er en kommentar
        public Actor()
        {
            
        }
        public Actor(string fname, string lname)
        {
            this.act_fname = fname;
            this.act_lname = lname;
        }

        public Actor(int id, string fname, string lname)
        :this(fname, lname)
        {
            this.Act_id = id;
        }

    }
}