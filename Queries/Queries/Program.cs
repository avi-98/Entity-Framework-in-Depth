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

            var course = context.Courses.Find(4); // .Single(c => c.Id == 4)
            if (course != null)
            {
                course.Name = "New Name";
                course.AuthorId = 2;
            }

            context.SaveChanges();
        }
    }
}