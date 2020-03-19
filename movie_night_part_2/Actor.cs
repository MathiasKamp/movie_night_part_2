namespace movie_night_part_2
{
    public class Actor
    {
        // attributes of Actor object
        public int Act_id { get; set; }
        public string act_fname { get; set; }
        public string act_lname { get; set; }

        // empty constructor
        public Actor()
        {
            
        }
        // Constructor with 2 parameters
        public Actor(string fname, string lname)
        {
            this.act_fname = fname;
            this.act_lname = lname;
        }

        // constructor with 3 parameters
        public Actor(int id, string fname, string lname)
        :this(fname, lname)
        {
            this.Act_id = id;
        }

    }
}