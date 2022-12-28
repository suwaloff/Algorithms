﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class Sorting
    {
        public IStrategy ContextStrategy { get; set; }

        public Sorting( IStrategy strategy) => ContextStrategy = strategy;
       
        public void Sort()
        {
            ContextStrategy.Sort();
        }
    }
}
