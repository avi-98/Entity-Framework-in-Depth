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
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new {AuthorName = a.Name, Courses = g.Count()};

            foreach (var x in query)
            {
                Console.WriteLine($@"{x.AuthorName}, ({x.Courses})");
            }
        }
    }
}
