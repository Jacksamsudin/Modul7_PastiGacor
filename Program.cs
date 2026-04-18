using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_PastiGacor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SOAL 1 ===");
            FilmFavorit_Tegar filmFavorit = new FilmFavorit_Tegar();
            filmFavorit.readJson();

            Console.WriteLine();
            Console.WriteLine("=== SOAL 2 ===");

            WatchList_Tegar watchList = new WatchList_Tegar();
            watchList.ReadJson();
        }   
    }
}
