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
            var actionMoviesSorted = context.Videos
                .Where(v => v.GenreId == 2)
                .OrderBy(v => v.Name);
            foreach (var video in actionMoviesSorted)
                Console.WriteLine(video.Name);

            Console.WriteLine();
            // Gold drama movies sorted by release date (newest first)
            var goldDramaMovies = context.Videos
                .Where(v => v.GenreId == 7 && v.Classification == Classification.Gold)
                .OrderByDescending(v => v.ReleaseDate);
            foreach (var video in goldDramaMovies)
                Console.WriteLine(video.Name);

            Console.WriteLine();
            // All movies projected into an anonymous type with two properties: MovieName and Genre
            var anonymousMovie = context.Videos
                .Select(v => new {MovieName = v.Name, Genre = v.Genre.Name});
            foreach (var video in anonymousMovie)
                Console.WriteLine($@"{video.MovieName}: {video.Genre}");

            Console.WriteLine();
            // All movies grouped by their classification
            var moviesGroupedByClassification = context.Videos
                .GroupBy(v => v.Classification,
                    (classification, videos) => new {Classification = classification, Movies = videos.OrderBy(v => v.Name)});
            foreach (var movieCollection in moviesGroupedByClassification)
            {
                Console.WriteLine($@"Classification: {movieCollection.Classification}");
                foreach (var video in movieCollection.Movies)
                    Console.WriteLine($@"   {video.Name}");
            }

            Console.WriteLine();
            // List of classifications sorted alphabetically and count of videos in them
            var classificationsSorted = context.Videos
                .GroupBy(v => v.Classification,
                    (classification, videos) => new {Classification = classification, Count = videos.Count()})
                .OrderBy(g => g.Classification.ToString());
            foreach (var group in classificationsSorted)
                Console.WriteLine($@"{group.Classification} ({group.Count})");

            Console.WriteLine();
            // List of genres and number of videos they include, sorted by the number of videos
            var genresSorted = context.Genres
                .GroupJoin(context.Videos, genre => genre.Id, video => video.GenreId,
                    (genre, videos) => new {Genre = genre.Name, Count = videos.Count()})
                .OrderByDescending(g => g.Count);
            foreach (var group in genresSorted)
                Console.WriteLine($@"{group.Genre} ({group.Count})");
        }
    }
}
