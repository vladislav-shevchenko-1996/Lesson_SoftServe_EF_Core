using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            Country country = new Country() { Name = "Ukraine" };
            Artist artist = new Artist() { Name = "Хтось", Surname = "Там", Country = country };
            Genre genre = new Genre() { Name = "Folk" };
            Album album = new Album() { Name = "Des' tam", Genre = genre, Artist = artist, Year = 2017 };
            Track track = new Track() { Name = "Yakos'", Album = album, Duration = 210 };
            Category category = new Category() { Name = "CP" };
            Playlist playlist = new Playlist() { Name = "Ne dlya Ludei", Category = category };
            playlist.AddTrack(track);
            context.Playlists.Add(playlist);
            //context.Countries.Add(new Country() { Name = "Catland" });
            context.SaveChanges();
            foreach (var c in context.Countries)
            {
                Console.WriteLine($"Country: {c.Name}");
            }
        }
    }
}
