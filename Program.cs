// See https://aka.ms/new-console-template for more information
using Modul7_PastiGacor;


public class Program
{
    public static void Main(string[] args)
    {
      filmFavorite_Rifki film = new filmFavorite_Rifki();

        film.ReadJson();

        WatchList watchList = new WatchList();
        watchList.ReadJson();
    }
    
        
    
}