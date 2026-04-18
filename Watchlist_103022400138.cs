using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace Modul7_PastiGacor
{
    internal class Watchlist_103022400138
    {
        public List<Watch> movies { get; set; }

        internal void ReadJSON()
        {
            try
            {
                string filepath = "jurnal7_2_103022400138.json";
                string jsonString = File.ReadAllText(filepath);
                Watchlist_103022400138 watchlist = JsonSerializer.Deserialize<Watchlist_103022400138>(jsonString);
                foreach (var movie in watchlist.movies)
                {
                    Console.WriteLine("Title: " + movie.title);
                    Console.WriteLine("Genre: " + movie.genre);
                    Console.WriteLine("Year: " + movie.year);
                    Console.WriteLine("Rating: " + movie.rating);
                    Console.WriteLine("ID: " + movie.id);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON: " + ex.Message);
            }
        }

        public class Watch
        {
            public string title { get; set; }
            public string genre { get; set; }
            public int year { get; set; }
            public int rating { get; set; }
            public string id { get; set; }

           
        }
    }
}
