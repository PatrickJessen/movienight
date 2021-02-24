using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Actor(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
    }
}
