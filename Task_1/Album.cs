using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
