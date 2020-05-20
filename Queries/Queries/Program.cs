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
            var authorIds = authors.Select(a => a.Id);

            context.Courses.Where(c => authorIds.Contains(c.AuthorId) && c.FullPrice == 0).Load();
        }
    }
}