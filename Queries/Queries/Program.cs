﻿using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            
            // Add an object
            context.Authors.Add(new Author {Name = "New Author"});

            // Update an object
            var author = context.Authors.Find(3);
            author.Name = "Updated";

            // Remove an object
            var another = context.Authors.Find(4);
            context.Authors.Remove(another);

            var entries = context.ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.State);
            }
        }
    }
}