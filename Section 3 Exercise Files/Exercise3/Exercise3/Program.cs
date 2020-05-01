using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyContext = new VidzyDbContext();

            PopulateTwilightMovies(vidzyContext);
            PopulateOriginalTrilogyMovies(vidzyContext);
            PopulatePrequelTrilogyMovies(vidzyContext);
            PopulateSequelTrilogyMovies(vidzyContext);
            PopulateAnthologyMovies(vidzyContext);
        }

        private static void PopulateAnthologyMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Rogue One: A Star Wars Story", new DateTime(year: 2016, month: 12, day: 16), 2);
            vidzyContext.AddVideo("Solo: A Star Wars Story", new DateTime(year: 2018, month: 5, day: 25), 2);
        }

        private static void PopulateSequelTrilogyMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Episode VII – The Force Awakens", new DateTime(year: 2015, month: 12, day: 18), 2);
            vidzyContext.AddVideo("Episode VIII – The Last Jedi", new DateTime(year: 2017, month: 12, day: 15), 2);
            vidzyContext.AddVideo("Episode IX – The Rise of Skywalker", new DateTime(year: 2019, month: 12, day: 20),
                2);
        }

        private static void PopulatePrequelTrilogyMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Episode I – The Phantom Menace", new DateTime(year: 1999, month: 5, day: 19), 2);
            vidzyContext.AddVideo("Episode II – Attack of the Clones", new DateTime(year: 2002, month: 5, day: 16), 2);
            vidzyContext.AddVideo("Episode III – Revenge of the Sith", new DateTime(year: 2005, month: 5, day: 19), 2);
        }

        private static void PopulateOriginalTrilogyMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Episode IV – A New Hope", new DateTime(year: 1977, month: 5, day: 25), 2);
            vidzyContext.AddVideo("Episode V – The Empire Strikes Back", new DateTime(year: 1980, month: 5, day: 21),
                2);
            vidzyContext.AddVideo("Episode VI – Return of the Jedi", new DateTime(year: 1983, month: 5, day: 25), 2);
        }

        private static void PopulateTwilightMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Twilight", new DateTime(year: 2008, month: 11, day: 21), 6);
            vidzyContext.AddVideo("The Twilight Saga: New Moon", new DateTime(year: 2009, month: 11, day: 20), 6);
            vidzyContext.AddVideo("The Twilight Saga: Eclipse", new DateTime(year: 2010, month: 6, day: 24), 6);
            vidzyContext.AddVideo("The Twilight Saga: Breaking Dawn – Part 1",
                new DateTime(year: 2011, month: 11, day: 18), 6);
            vidzyContext.AddVideo("The Twilight Saga: Breaking Dawn – Part 2",
                new DateTime(year: 2012, month: 11, day: 12), 6);
        }
    }
}
