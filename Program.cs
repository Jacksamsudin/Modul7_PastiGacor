
using Modul7_PastiGacor;

public class Program
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400077 filmFavorit = new FilmFavorit_103022400077();
        filmFavorit.ReadJSON();
        Console.WriteLine(); // Menambahkan baris kosong untuk pemisah

        Watchlist_103022400077 watchlist = new Watchlist_103022400077();
        watchlist.ReadJSON();

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
