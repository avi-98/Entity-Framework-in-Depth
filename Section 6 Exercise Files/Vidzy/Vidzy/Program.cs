using System;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            // Action movies sorted by name
            var moviesSortedByName = context.Videos
                .Where(v => v.GenreId == 2)
                .OrderBy(v => v.Name);
            foreach (var video in moviesSortedByName)
                Console.WriteLine(video.Name);
        }
    }
}
