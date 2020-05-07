using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var groups = context.Courses.GroupBy(c => c.Level);

            foreach (var group in groups)
            {
                Console.WriteLine($@"Key: {group.Key}");

                foreach (var course in group)
                {
                    Console.WriteLine($@"   {course.Name}");
                }
            }
        }
    }
}
