

using System;
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
            {
                Console.WriteLine($"Video Name: {video.Name}\t Video Genre: {video.Genre.Name}");
            }
        }
    }
}
