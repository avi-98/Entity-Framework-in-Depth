using System.Collections.Generic;

namespace Exercise4
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }

        public Tag()
        {
            Videos = new HashSet<Video>();
        }
    }
}