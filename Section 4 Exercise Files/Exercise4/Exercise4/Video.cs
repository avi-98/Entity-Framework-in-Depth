﻿using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}