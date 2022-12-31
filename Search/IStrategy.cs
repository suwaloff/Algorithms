using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public interface IStrategy
    {
        int Search(int key, int[] myArray);
    }
}
