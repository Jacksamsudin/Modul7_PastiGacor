using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace Modul7_PastiGacor
{
    internal class filmFavorite_Rifki
    {
        public string title{get; set; }
        public string director { get; set; }
        public int tahun { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }


    
     public void ReadJson()
        {
            //string jsonFilePath = "D:\\mod7\\Modul7_PastiGacor\\bin\\Debug\\net10.0\\jurnal7_1_10302400057.json";
            string jsonString = File.ReadAllText("D:\\mod7\\Modul7_PastiGacor\\bin\\Debug\\net10.0\\jurnal7_1_103022400057.json");

            filmFavorite_Rifki film = JsonSerializer.Deserialize<filmFavorite_Rifki>(jsonString);

            Console.WriteLine("Title: " + film.title);
            Console.WriteLine("Director: " + film.director);
            Console.WriteLine("Tahun: " + film.tahun);
            Console.WriteLine("Genre: " + film.genre);
            Console.WriteLine("Rating: " + film.rating);
            Console.WriteLine("Duration (minutes): " + film.durationMinutes);
            Console.WriteLine("Is Watched: " + film.isWatched);

        }


    }
}