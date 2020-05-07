using Exercise4.EntityConfiguration;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
        }
    }
}