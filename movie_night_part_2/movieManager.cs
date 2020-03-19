using System.Collections.Generic;

namespace movie_night_part_2
{
    public static class movieManager
    {
        
        public static Actor InsertActor(Actor a)
        {
            return ServerManager.InsertActor(a);
        }

        public static Movie InsertMovie(Movie m)
        {
            return ServerManager.InsertMovie(m);
        }

        public static Genre InsertGenre(Genre g)
        {
            return ServerManager.InsertGenre(g);
        }

        public static Actor UpdateActorName(Actor a)
        {
            return ServerManager.UpdateActorName(a);
        }

        public static Actor DelteActor(Actor a)
        {
            return ServerManager.DeleteActor(a);
        }
    }
}