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
        // connection string to connect to database
        private static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDB_1;Integrated Security=True";

        // method to insert a sql new actor into actor table
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

        // method to insert a new movie into movie table
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

        // method to insert a new genre into genre table
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
        // method to update actor, it will update act_fname, act_lname column
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

        // method to delete an actor from actor table with the act_fname 'Matte'
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