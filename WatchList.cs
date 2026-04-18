using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class WatchList
    {

            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
            
             public string watchlistName { get; set; }
        public Movie[] movies { get; set; }

        public void ReadJson()
        {
            string jsonString = File.ReadAllText("D:\\mod7\\Modul7_PastiGacor\\bin\\Debug\\net10.0\\jurnal7_2_103022400057.json");
            WatchList watchList = JsonSerializer.Deserialize<WatchList>(jsonString);
            
            Console.WriteLine("Watch List:" + watchList.watchlistName);
            Console.WriteLine("ID: " + watchList.id);

            foreach (Movie movie in watchList.movies)
            {
                Console.WriteLine("Title: " + movie.title);
                Console.WriteLine("Year: " + movie.year);
                Console.WriteLine("Genre: " + movie.genre);
                Console.WriteLine("Rating: " + movie.rating);
                Console.WriteLine();
            }
        }

    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }


}
