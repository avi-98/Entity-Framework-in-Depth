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

            var authors = context.Authors.ToList();
            var author = context.Authors.Single(a => a.Id == 1);

            var course = new Course
            {
                Name = "New Course 2",
                Description = "New Description",
                FullPrice = 19.95f,
                Level = 1,
                Author = author
            };

            context.Courses.Add(course);

            context.SaveChanges();
        }
    }
}