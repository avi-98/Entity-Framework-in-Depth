using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            context.Courses.Join(context.Authors,
                c => c.AuthorId,
                a => a.Id,
                (course, author) => new
                {
                    CourseName = course.Name,
                    AuthorName = author.Name
                });
        }
    }
}
