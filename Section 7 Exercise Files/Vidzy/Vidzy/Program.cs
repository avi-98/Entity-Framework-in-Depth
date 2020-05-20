

using System;
using System.Data.Entity;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var videos = context.Videos.ToList();

            foreach (var video in videos)
                Console.WriteLine($"Video Name: {video.Name}\t Video Genre: {video.Genre.Name}");


            var videosWithGenre = context.Videos.Include(v => v.Genre).ToList();
            foreach (var video in videosWithGenre)
                Console.WriteLine($"Video Name: {video.Name}\t Video Genre: {video.Genre.Name}");

        }
    }
}
