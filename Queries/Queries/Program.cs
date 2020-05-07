using System;
using System.Diagnostics.Eventing;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // LINQ Syntax
            var query = from c in context.Courses
                where c.Name.Contains("C#")
                orderby c.Name
                select c;

            foreach (var course in query)
                Console.WriteLine(course.Name);

            // Extension Methods
            var courses = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }
        }
    }
}
