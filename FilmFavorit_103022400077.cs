using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class FilmFavorit_103022400077
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }
        public void ReadJSON()
        {
            //Baca file Json
            string jsonString = File.ReadAllText("jurnal7_1_103022400077.json");
            //Deserialize file json
            FilmFavorit_103022400077 film = JsonSerializer.Deserialize<FilmFavorit_103022400077>(jsonString);
            // print data
            Console.WriteLine($"Judul Film: {film.title}");
            Console.WriteLine($"Sutradara: {film.director}");
            Console.WriteLine($"Tahun Rilis: {film.year}");
            Console.WriteLine($"Genre: {film.genre}");
            Console.WriteLine($"Rating: {film.rating}");
            Console.WriteLine($"Durasi: {film.durationMinutes} menit");
            Console.WriteLine($"Sudah Ditonton: {(film.isWatched ? "Ya" : "Tidak")}");

        }
    }

}
