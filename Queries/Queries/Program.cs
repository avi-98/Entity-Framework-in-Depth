using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var author = context.Authors.Single(a => a.Id == 1);

            // MSDN
            context.Entry(author).Collection(a => a.Courses).Query().Where(c => c.FullPrice == 0).Load(); // For single entries ONLY

            // Mosh
            context.Courses.Where(c => c.AuthorId == author.Id && c.FullPrice == 0).Load();

            foreach (var course in author.Courses)
                Console.WriteLine($@"{course.Name}");
        }
    }
}