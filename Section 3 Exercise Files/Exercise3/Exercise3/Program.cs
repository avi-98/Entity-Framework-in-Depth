using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyContext = new VidzyDbContext();

            PopulateMarvelPhaseOneMovies(vidzyContext);
            PopulateMarvelPhaseTwoMovies(vidzyContext);
            PopulateMarvelPhaseFourMovies(vidzyContext);
        }

        private static void PopulateMarvelPhaseFourMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Captain America: Civil War", new DateTime(year: 2016, month: 5, day: 6), "Action");
            vidzyContext.AddVideo("Doctor Strange", new DateTime(year: 2016, month: 11, day: 4), "Action");
            vidzyContext.AddVideo("Guardians of the Galaxy Vol. 2", new DateTime(year: 2017, month: 5, day: 5), "Action");
            vidzyContext.AddVideo("Spider-Man: Homecoming", new DateTime(year: 2017, month: 7, day: 7), "Action");
            vidzyContext.AddVideo("Thor: Ragnarok", new DateTime(year: 2017, month: 11, day: 3), "Action");
            vidzyContext.AddVideo("Black Panther", new DateTime(year: 2018, month: 2, day: 16), "Action");
            vidzyContext.AddVideo("Avengers: Infinity War", new DateTime(year: 2018, month: 4, day: 27), "Action");
            vidzyContext.AddVideo("Ant-Man and the Wasp", new DateTime(year: 2018, month: 7, day: 6), "Action");
            vidzyContext.AddVideo("Captain Marvel", new DateTime(year: 2019, month: 3, day: 8), "Action");
            vidzyContext.AddVideo("Avengers: Endgame", new DateTime(year: 2019, month: 4, day: 26), "Action");
            vidzyContext.AddVideo("Spider-Man: Far From Home", new DateTime(year: 2019, month: 7, day: 2), "Action");
        }

        private static void PopulateMarvelPhaseTwoMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Iron Man 3", new DateTime(year: 2013, month: 5, day: 3), "Action");
            vidzyContext.AddVideo("Thor: The Dark World", new DateTime(year: 2013, month: 11, day: 8), "Action");
            vidzyContext.AddVideo("Captain America: The Winter Soldier", new DateTime(year: 2014, month: 4, day: 4), "Action");
            vidzyContext.AddVideo("Guardians of the Galaxy", new DateTime(year: 2014, month: 9, day: 1), "Action");
            vidzyContext.AddVideo("Avengers: Age of Ultron", new DateTime(year: 2015, month: 5, day: 1), "Action");
            vidzyContext.AddVideo("Ant-Man", new DateTime(year: 2015, month: 7, day: 17), "Action");
        }

        private static void PopulateMarvelPhaseOneMovies(VidzyDbContext vidzyContext)
        {
            vidzyContext.AddVideo("Iron Man", new DateTime(year: 2008, month: 5, day: 2), "Action");
            vidzyContext.AddVideo("The Incredible Hulk", new DateTime(year: 2008, month: 6, day: 13), "Action");
            vidzyContext.AddVideo("Iron Man 2", new DateTime(year: 2010, month: 5, day: 7), "Action");
            vidzyContext.AddVideo("Thor", new DateTime(year: 2011, month: 5, day: 6), "Action");
            vidzyContext.AddVideo("Captain America: The First Avenger", new DateTime(year: 2011, month: 7, day: 22),
                "Action");
            vidzyContext.AddVideo("Marvel's The Avengers", new DateTime(year: 2012, month: 5, day: 4), "Action");
        }
    }
}
