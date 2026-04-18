using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class FilmFavorit_103022400138
    {
        public string title { get; set; }
        public string genre { get; set; }
        public string year { get; set; }
        public int rating { get; set; }
        public string director { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJSON()
        {
            try
            {
                string filepath = "FilmFavorit_103022400138.json";
                string jsonString = File.ReadAllText(filepath);

                FilmFavorit_103022400138 film = JsonSerializer.Deserialize<FilmFavorit_103022400138>(jsonString);

                Console.WriteLine("Title: " + film.title);
                Console.WriteLine("Genre: " + film.genre);
                Console.WriteLine("Year: " + film.year);
                Console.WriteLine("Rating: " + film.rating);
                Console.WriteLine("Director: " + film.director);
                Console.WriteLine("Duration (minutes): " + film.durationMinutes);
                Console.WriteLine("Watched: " + (film.isWatched ? "Yes" : "No"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON: " + ex.Message);
            }
        }

    }
}
