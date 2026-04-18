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
    }
}
