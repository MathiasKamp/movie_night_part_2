using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Net.Sockets;

namespace movie_night_part_2
{
    public static class ServerManager
    {
        private static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDB_1;Integrated Security=True";


        public static Actor InsertActor(Actor a)
        {
            string insertString = "insert into actor (act_fname, act_lname) values ('john', 'hitler');";
            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(insertString, connection);


                cmd.ExecuteNonQuery();
            }
            return a;
        }


        public static Movie InsertMovie(Movie m)
        {
            string insertString =
                "insert into movie(mov_year, mov_title, mov_description) values(2012, '2012', 'A frustrated writer struggles to keep his family alive when a series of global catastrophes threatens to annihilate mankind.')";
            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(insertString, connection);


                cmd.ExecuteNonQuery();
            }
            return m;
        }

        public static Genre InsertGenre(Genre g)
        {
            string insertString = "insert into genre (gen_type) values ('Science Fiction')";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand (insertString,connection);

                cmd.ExecuteNonQuery();
            }

            return g;
        }

        public static Actor UpdateActorName (Actor a)
        {
            string insertString = "update actor set act_fname = 'Matte', act_lname = 'Kamp' where act_fname like '%Mathias%'";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(insertString, connection);

                cmd.ExecuteNonQuery();
            }

            return a;
        }

        public static Actor DeleteActor(Actor a)
        {
            string insertString = "delete actor where act_fname = 'Matte'";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(insertString, connection);

                cmd.ExecuteNonQuery();
            }

            return a;
        }
    }
}