using System.Collections.Generic;

namespace movie_night_part_2
{
    public static class movieManager
    {
        // class the InsertActor() method from serverManager
        public static Actor InsertActor(Actor a)
        {
            return ServerManager.InsertActor(a);
        }
        // class the InsertMovie() method from serverManager
        public static Movie InsertMovie(Movie m)
        {
            return ServerManager.InsertMovie(m);
        }
        // class the InsertGenre() method from serverManager
        public static Genre InsertGenre(Genre g)
        {
            return ServerManager.InsertGenre(g);
        }
        // class the UpdateActorName() method from serverManager
        public static Actor UpdateActorName(Actor a)
        {
            return ServerManager.UpdateActorName(a);
        }
        // class the DeleteActor() method from serverManager
        public static Actor DeleteActor(Actor a)
        {
            return ServerManager.DeleteActor(a);
        }
    }
}