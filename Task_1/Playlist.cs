using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public Category Category { get; set; }
        public Playlist()
        {
            Tracks = new List<Track>();
        }
        

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
