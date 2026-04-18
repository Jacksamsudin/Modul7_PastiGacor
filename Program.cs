using System.Text.Json;
namespace Modul7_PastiGacor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103022400138 filmFavorit = new FilmFavorit_103022400138();
            
            filmFavorit.ReadJSON();

            Console.WriteLine();

            Watchlist_103022400138 watchlist = new Watchlist_103022400138();

            watchlist.ReadJSON();
        }
    }
}