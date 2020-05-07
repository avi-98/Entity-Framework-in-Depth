using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public Video()
        {
            Tags = new HashSet<Tag>();
        }
    }
}