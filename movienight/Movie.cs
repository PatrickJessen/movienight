using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Movie(int id, string title, string description, int year, string genre)
        {
            Id = id;
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }
    }
}
