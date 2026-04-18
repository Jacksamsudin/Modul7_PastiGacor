using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_PastiGacor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_Tegar filmFavorit = new FilmFavorit_Tegar();
            filmFavorit.readJson();
        }
    }
}
