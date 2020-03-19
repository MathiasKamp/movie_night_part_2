using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace movie_night_part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Actor a1 = new Actor("Mogens", "Miskat");

            movieManager.InsertActor(a1);


            Movie m = new Movie(2004, "The Day After Tomorrow", "Jack Hall, paleoclimatologist, must make a daring trek from Washington, D.C. to New York City to reach his son, trapped in the cross-hairs of a sudden international storm which plunges the planet into a new Ice Age.");

            movieManager.InsertMovie(m);

            Genre g = new Genre("Science Fiction");
            movieManager.InsertGenre(g);

            Actor a2 = new Actor("Matte", "Kamp");

            movieManager.UpdateActorName(a2);

            Actor a3 = new Actor("Matte", "Kamp");

            movieManager.DelteActor(a3);


        }

        
    }
}
