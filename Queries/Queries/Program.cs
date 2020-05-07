﻿using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var query = from c in context.Courses
                group c by c.Level
                into g
                select g;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);

                foreach (var course in group)
                {
                    Console.WriteLine($@"	 {course.Name}");
                }
            }
        }
    }
}