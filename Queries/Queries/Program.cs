using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var courses = context.Courses
                .Where(c => c.IsBeginnerCourse == true);

            foreach (var course in courses)
                Console.WriteLine(course.Name);
        }
    }
}