using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    class DalManager
    {
        public static string ConString { get; } = "Server=DESKTOP-HHVS23D;Database=movienight;Trusted_Connection=True;";

        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            string query = "SELECT id, title, description, year, genre FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["title"];
                    string description = (string)reader["description"];
                    int year = (int)reader["year"];
                    string genre = (string)reader["genre"];

                    Movie movie = new Movie(id, title, description, year, genre);
                    movieList.Add(movie);
                }
                return movieList;
            }
        }

        public static List<Actor> GetActors()
        {
            List<Actor> actorList = new List<Actor>();
            string query = "SELECT id, fname, lastname FROM actor";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["fname"];
                    string lastName = (string)reader["lastname"];

                    Actor actor = new Actor(id, name, lastName);
                    actorList.Add(actor);
                }
                return actorList;
            }
        }

        public static List<Movie> SearchMovie(string search)
        {
            List<Movie> movieList = new List<Movie>();
            string query = "SELECT id, title, description, year, genre FROM movie WHERE title like @search";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter parameter = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["title"];
                    string description = (string)reader["description"];
                    int year = (int)reader["year"];
                    string genre = (string)reader["genre"];

                    Movie movie = new Movie(id, title, description, year, genre);
                    movieList.Add(movie);
                }
                return movieList;
            }
        }

        public static List<Actor> SearchActor(string search)
        {
            List<Actor> actorList = new List<Actor>();
            string query = "SELECT id, fname, lastname FROM actor WHERE fname like @search";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter parameter = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["fname"];
                    string description = (string)reader["lastname"];

                    Actor actor = new Actor(id, title, description);
                    actorList.Add(actor);
                }
                return actorList;
            }
        }

        public static List<Movie> SearchMovieByGenre(string search)
        {
            List<Movie> movieList = new List<Movie>();
            string query = "SELECT * FROM movie WHERE genre LIKE @search";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter parameter = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["title"];
                    string description = (string)reader["description"];
                    int year = (int)reader["year"];
                    string genre = (string)reader["genre"];

                    Movie movie = new Movie(id, title, description, year, genre);
                    movieList.Add(movie);
                }
                return movieList;
            }
        }
    }
}
