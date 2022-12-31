using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class Sorting
    {
        private IStrategy SortingStrategy { get; set; }
        
        public Sorting(IStrategy strategy)
        {
            SortingStrategy = strategy;
        }  
       
        public void Sort()
        {
            SortingStrategy.Sort();
        }
    }
}
