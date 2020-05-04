using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyContext = new VidzyDbContext();

            const byte classification = (byte)Classification.Gold;
            vidzyContext.AddVideo("Coyote Ugly", new DateTime(year: 2000, month: 9, day: 4), 6, classification);
        }
    }
}
