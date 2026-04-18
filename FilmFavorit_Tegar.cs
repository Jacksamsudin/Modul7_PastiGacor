using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class FilmFavorit_Tegar
    {
        public string title { get; set; }

        public string director { get; set; }

        public string year { get; set; }

        public string genre { get; set; }

        public int rating { get; set; }

        public int durationMinutes { get; set; }

        public bool isWatched { get; set; }


        public void readJson()
        {
         
            string jsonString = File.ReadAllText("jurnal7_1_103022400074.json");

            FilmFavorit_Tegar filmFavorit = JsonSerializer.Deserialize<FilmFavorit_Tegar>(jsonString);

            Console.WriteLine("Title: " + filmFavorit.title);
            Console.WriteLine("Director: " + filmFavorit.director);
            Console.WriteLine("Year: " + filmFavorit.year);
            Console.WriteLine("Genre: " + filmFavorit.genre);
            Console.WriteLine("Rating: " + filmFavorit.rating);
            Console.WriteLine("Duration (minutes): " + filmFavorit.durationMinutes);
            Console.WriteLine("Watched: " + (filmFavorit.isWatched ? "Yes" : "No"));


        }
    }
}