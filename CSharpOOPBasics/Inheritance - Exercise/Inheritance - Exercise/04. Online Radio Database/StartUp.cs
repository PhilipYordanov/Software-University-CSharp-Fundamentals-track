using _04.Online_Radio_Database.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Online_Radio_Database
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                var songTokens = Console.ReadLine()
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                try
                {
                    var songLenTokens = songTokens[2]
                        .Split(':')
                        .ToArray();

                    int minutes;
                    int seconds;
                    if (int.TryParse(songLenTokens[0], out minutes) && int.TryParse(songLenTokens[1], out seconds))
                    {
                        playlist.Add(new Song(songTokens[0], songTokens[1], minutes, seconds));
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int totalPlaylistLength = 0;
            foreach (var song in playlist)
            {
                totalPlaylistLength += song.Minutes * 60 + song.Seconds;
            }
            int totalMinutes = totalPlaylistLength / 60;
            int totalSeconds = totalPlaylistLength % 60;
            int hours = totalMinutes / 60;
            totalMinutes %= 60;

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {hours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}
