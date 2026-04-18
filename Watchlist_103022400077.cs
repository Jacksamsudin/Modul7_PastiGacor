using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class Watchlist_103022400077
    {
            public string watchlistName { get; set; }
            public string createdBy { get; set; }
            public List<movie> movies { get; set; }

        public void ReadJSON()
        {
            //Baca file Json
            string jsonString = File.ReadAllText("jurnal7_2_103022400077.json");
            // Deserialize json ke wrapper
            Watchlist_103022400077 wl = JsonSerializer.Deserialize<Watchlist_103022400077>(jsonString);
            // print data
            Console.WriteLine($"Watchlist Name : {wl.watchlistName}");
            Console.WriteLine($"Created By : {wl.createdBy}");
            Console.WriteLine($"Movies : ");
            for (int i = 0; i < wl.movies.Count; i++)
            {
                Console.WriteLine($"{wl.movies[i].id} {wl.movies[i].title} ({wl.movies[i].year} - {wl.movies[i].rating})");
            }
        }
    }
    public class movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }

        public movie(string id, string title, int year, string genre, double rating)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.rating = rating;
        }
    }
}
