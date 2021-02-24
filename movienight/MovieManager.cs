using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    static class MovieManager
    {
        public static List<Movie> ReturnMovie()
        {
            return DalManager.GetMovies();
        }

        public static List<Actor> ReturnActor()
        {
            return DalManager.GetActors();
        }

        public static List<Movie> ReturnMovieBySearch(string search)
        {
            return DalManager.SearchMovie(search);
        }

        public static List<Actor> ReturnActorBySearch(string search)
        {
            return DalManager.SearchActor(search);
        }

        public static List<Movie> ReturnMovieByGenre(string search)
        {
            return DalManager.SearchMovieByGenre(search);
        }
    }
}
