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
            // creates new object a1 of actor class
            Actor a1 = new Actor("Mogens", "Miskat");
            // call InsertActor() method from movieManager
            movieManager.InsertActor(a1);

            // Create new object m from Movie class
            Movie m = new Movie(2004, "The Day After Tomorrow", "Jack Hall, paleoclimatologist, must make a daring trek from Washington, D.C. to New York City to reach his son, trapped in the cross-hairs of a sudden international storm which plunges the planet into a new Ice Age.");

            // call InsertMovie() method from movieManger
            movieManager.InsertMovie(m);
            // creates new object g of Genre Class
            Genre g = new Genre("Science Fiction");

            // call Insertgenre() method movieManager
            movieManager.InsertGenre(g);
            
            // creates new object a2 of Actor class
            Actor a2 = new Actor("Matte", "Kamp");

            // call UpdateActorName() method from movieManager
            movieManager.UpdateActorName(a2);

            // create new object a3 of Actor Class
            Actor a3 = new Actor("Matte", "Kamp");

            // call DeleteActor() method from movieManager
            movieManager.DeleteActor(a3);


        }

        
    }
}
