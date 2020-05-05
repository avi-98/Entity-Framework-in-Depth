namespace Exercise4
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VidzyModel : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyModel()
            : base("name=VidzyModel")
        {
        }
    }
}