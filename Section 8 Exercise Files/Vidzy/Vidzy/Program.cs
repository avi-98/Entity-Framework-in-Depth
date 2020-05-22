using System;
using System.Data.Entity;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            AddVideo(new Video()
            {
                Name = "Terminator 1",
                GenreId = 2,
                Classification = Classification.Silver,
                ReleaseDate = new DateTime(year: 1984, month: 10, day: 26)
            });

            // Exercise 2
            AddTags("classics", "drama");

            // Exercise 3
            AddTagsToVideo(videoId: 1, "classics", "drama", "comedy");

            // Exercise 4
            RemoveTagsFromVideo(videoId: 1, "comedy");

            // Exercise 5
            RemoveVideo(videoId: 1);

            // Exercise 6
            RemoveGenre(2, enforceDeletingVideos: true);
        }

        public static void AddVideo(Video video)
        {
            using (var context = new VidzyContext())
            {
                context.Videos.Add(video);
                context.SaveChanges();
            }
        }   

        public static void AddTags(params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var name in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                        context.Tags.Add(new Tag {Name = name});
                }

                context.SaveChanges();
            }
        }

        public static void AddTagsToVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.CurrentCultureIgnoreCase)))
                        tags.Add(new Tag {Name = tagName});
                }

                var video = context.Videos.Single(v => v.Id == videoId);

                tags.ForEach(t => video.AddTag(t));

                context.SaveChanges();
            }
        }

        public static void RemoveTagsFromVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                context.Tags.Where(t => tagNames.Contains(t.Name)).Load();

                var video = context.Videos.Single(v => v.Id == videoId);

                foreach (var tagName in tagNames)
                {
                    video.RemoveTag(tagName);
                }

                context.SaveChanges();
            }
        }

        private static void RemoveVideo(int videoId)
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.Single(v => v.Id == videoId);
                if (video == null) return;

                context.Videos.Remove(video);
                context.SaveChanges();
            }
        }

        private static void RemoveGenre(int genreId, bool enforceDeletingVideos)
        {
            using (var context = new VidzyContext())
            {
                var genre = context.Genres.Include(g => g.Videos).SingleOrDefault(g => g.Id == genreId);
                if (genre == null) return;

                if (enforceDeletingVideos)
                    context.Videos.RemoveRange(genre.Videos);

                context.Genres.Remove(genre);
                context.SaveChanges();
            }
        }
    }
}
