﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Album Album { get; set; }
        public int Duration { get; set; }
    }
}
