using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var count = context.Courses.Where(c => c.Level == 1).Count();
            var count2 = context.Courses.Count(c => c.Level == 1); // Filtering the count for courses that are level one

            context.Courses.Max(c => c.FullPrice);
            context.Courses.Min(c => c.FullPrice);
            context.Courses.Average(c => c.FullPrice);
        }
    }
}