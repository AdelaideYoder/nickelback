using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a List, named goodSongs, that will hold tuples consisting of two strings.

            List<(string artist, string song)> goodSongs = new List<(string artist, string song)>();

            //Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
            //The name of an artist
            //A song by that artist

            HashSet<(string artist, string song)> allSongs = new HashSet<(string artist, string song)>()
            {
                ("Nickleback", "Burn It To The Ground"),
                ("Nickleback", "Lullaby"),
                ("Nickleback", "Never Gonna Be Along"),
                ("Nickleback", "Song On Fire"),
                ("Rolling Stones", "Brown Sugar"),
                ("Beatles", "Yellow Submarine"),
                ("Muse", "Super Massive Black Hole"),
            };
            //Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
            foreach ((string artist, string song) song in allSongs)
            {
                //If the band is not Nickelback, then add it to the goodSongs list.
                if (song.artist != "Nickleback")
                {
                    goodSongs.Add((song.artist, song.song));
                }
            }
            //USe another foreach loop to print out all the good songs.
            foreach ((string artist, string song) song in goodSongs)
            {
                System.Console.WriteLine($"{song.artist}, {song.song}");
            }
        }
    }
}
