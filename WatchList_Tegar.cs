using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class WatchList_Tegar
    { 
        public string watchlistName { get; set; }

        public string createdBy { get; set; }

        public Movie[] movies { get; set; }
        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400074.json");
            WatchList_Tegar watchList = JsonSerializer.Deserialize<WatchList_Tegar>(jsonString);
            Console.WriteLine("Watch List Name: " + watchList.watchlistName);
            Console.WriteLine("Created By: " + watchList.createdBy);

            foreach (Movie movie in watchList.movies)
            {
                Console.WriteLine( movie.id + " Title: " + movie.title + " Year: " + movie.year + " Rating: " + movie.rating);
            
             
                
            }

        }
    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }

        public string genre { get; set; }

        public float rating { get; set; }
    }
}

