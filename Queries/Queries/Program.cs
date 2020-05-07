using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var query =
                from a in context.Authors
                from c in context.Courses
                select new {AuthorName = a.Name, CourseName = c.Name};

            foreach (var x in query)
            {
                Console.WriteLine($@"{x.AuthorName} - {x.CourseName}");
            }
        }
    }
}
