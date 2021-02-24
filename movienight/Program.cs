using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movie = MovieManager.ReturnMovie();
            List<Actor> actor = MovieManager.ReturnActor();
            List<Movie> searchMovie = MovieManager.ReturnMovieBySearch("Harry Potter");
            List<Actor> searchActor = MovieManager.ReturnActorBySearch("Daniel");
            List<Movie> searchGenre = MovieManager.ReturnMovieByGenre("Magic");
            foreach (Movie item in movie)
            {
                Console.WriteLine(item.Title);
            }

            foreach (Actor item in actor)
            {
                Console.WriteLine(item.Name);
            }

            foreach (Movie item in searchMovie)
            {
                Console.WriteLine(item.Title);
            }

            foreach (Actor item in searchActor)
            {
                Console.WriteLine(item.Name);
            }

            foreach (Movie item in searchGenre)
            {
                Console.WriteLine(item.Title);
            }

            Console.ReadKey();
        }
    }
}
