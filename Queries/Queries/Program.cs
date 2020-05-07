using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var allAbove10Dollars = context.Courses.All(c => c.FullPrice > 10);
            context.Courses.Any(c => c.Level == 1);
        }
    }
}