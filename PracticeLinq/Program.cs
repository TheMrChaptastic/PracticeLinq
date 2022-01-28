﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Guild Wars", "Guild Wars 2", "Final Fantasy 14", "Halo", "Osu!", "Sound Voltex", "Rocket League"};
            videoGames = videoGames.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            videoGames.ForEach(x => Console.WriteLine(x));

        }
    }
}
