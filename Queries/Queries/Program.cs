using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            context.Courses.OrderBy(c => c.Level)
                .FirstOrDefault(c => c.FullPrice > 100);
            // context.Courses.LastOrDefault(); This does not translate to an SQL Query
            context.Courses.SingleOrDefault(c => c.Id == 1);
        }
    }
}